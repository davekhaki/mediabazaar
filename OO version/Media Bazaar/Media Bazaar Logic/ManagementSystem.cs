using Media_Bazaar_Data_Access_Logic;
using Media_Bazaar_Logic.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Media_Bazaar_Logic.MailLogic;

namespace Media_Bazaar_Logic
{
    public class ManagementSystem
    {
        private readonly UserDal userDal = new UserDal();
        private readonly DepartmentDal departmentManager = new DepartmentDal();

        private readonly List<User> users;
        private readonly List<Schedule> schedules;
        private readonly List<Department> departments;
        private readonly MailSender mailer;

        public ManagementSystem()
        {
            this.users = GetAllEmployees();
            this.departments = GetAllDepartments();
            this.schedules = GetAllSchedules();
            mailer = new MailSender();
        }

        #region User related methods

        private List<User> GetAllEmployees()
        {
            var list = new List<User>();
            var allEmployees = userDal.GetAllEmployees();
            foreach (DataRow row in allEmployees.Rows)
            {
                var id = (int)row["id"];
                var firstname = (string)row["firstname"];
                var lastname = (string)row["lastname"];
                var age = (int)row[3];
                var gender = (string)row[4];
                var department = (string)row[5];
                var hireDate = (DateTime)row[6];
                var salary = (int)row[8];
                var address = (string)row[9];
                var username = (string)row["username"];
                var password = (string)row["password"];
                var email = (string)row["email"];
                var role = (string)row["role"];

                var e = new Employee(id, firstname, lastname, age, gender, department, hireDate, salary, address, username, password, email, role);
                list.Add(e);
            }
            return list;
        }

        public User[] GetUsers()
        {
            return this.users.ToArray();
        }

        public User GetUserById(int id)
        {
            return users.Find(x => x.Id == id); //finds a user n the list with the given id
        }

        #endregion

        #region Department methods

        private List<Department> GetAllDepartments()
        {
            var list = new List<Department>();
            var dataTable = departmentManager.GetAllDepartments();
            foreach (DataRow row in dataTable.Rows)
            {
                var id = (int)row["id"];
                var name = (string)row["name"];
                var d = new Department(id, name);
                list.Add(d);
            }
            return list;
        }
        public Department[] GetDepartments()
        {
            return this.departments.ToArray();
        }

        public Department GetDepartmentById(int id) => departments.Find(d => d.Id == id);

        public void UpdateDetails(int id, string oldName, string newName)
        {
            if (oldName == newName) return; // also checks if null
            var oldDepartment = GetDepartmentById(id);
            var updatedDepartment = new Department(id, newName);

            var index = departments.IndexOf(oldDepartment);
            if(index != -1) departments[index] = updatedDepartment;

            departmentManager.UpdateDetails(id, oldName, newName);
        }

        #endregion

        #region Schedule related methods

        private List<Schedule> GetAllSchedules()
        {
            var list = new List<Schedule>();
            var dataTable = userDal.GetSchedules();
            foreach (DataRow row in dataTable.Rows)
            {
                var empId = (int)row["employeeId"];
                var time = (string)row["time"];
                var day = (DateTime)row["day"];
                var s = new Schedule(empId, time, day);
                list.Add(s);
            }

            return list;
        }

        public DateTime[] GetScheduledDates(Employee e)
        {
            return (from s in schedules where s.EmpId == e.Id select s.Day).ToArray();
        }

        public List<Schedule> GetScheduleInfo(Employee e, DateTime day)
        {
            var list = new List<Schedule>();

            foreach (var s in schedules)
            {
                if (e.Id == s.EmpId && s.Day == day)
                {
                    list.Add(s);
                }


            }

            return list;
        }

        #endregion

        #region Login / profile

        public bool Login(string username, string password)
        {
            foreach (var u in users.Where(u => username == u.Username))
            {
                if (password == u.Password)
                {
                    return true;
                }
                MessageBox.Show("Username or password is incorrect.");
            }

            return false;
        }

        public void ChangeUsername(User u, string oldUsername, string newUsername)
        {
            if (string.IsNullOrWhiteSpace(newUsername)) return;
            if (oldUsername != u.Username) MessageBox.Show("Old username does not match current username");
            userDal.UpdateUsername(oldUsername, newUsername);
            mailer.SendEmail(u.Email, "Changed username", $"Your username has been changed to {newUsername}");
            MessageBox.Show("Username changed successfully");
        }

        public void ChangePassword(User u, string oldPass, string newPass, string newPassConfirm)
        {
            if (string.IsNullOrWhiteSpace(newPass)) return;
            if (oldPass != u.Password) MessageBox.Show("Old password is incorrect");
            else
            {
                if (newPass != newPassConfirm) MessageBox.Show("New password and new password confirm must match");
                else
                {
                    userDal.UpdatePassword(u.Username, newPass);
                    mailer.SendEmail(u.Email, "Password Change",
                        "Your password has been changed, if this was not you please contact a system administrator.");
                    MessageBox.Show("Password changed successfully");
                }
            }
        }

        public User GetDetails(string username, string password)
        {
            var userDetails = userDal.GetEmployeeDetails(username);
            foreach (DataRow row in userDetails.Rows)
            {
                var id = (int)row[0];
                var firstname = (string)row[1];
                var lastname = (string)row[2];
                var age = (int)row[3];
                var gender = (string)row[4];
                var department = (string)row[5];
                var hireDate = (DateTime)row[6];
                var salary = (int)row[8];
                var address = (string)row[9];
                var role = (string)row["role"];
                var email = (string)row["email"];

                var e = new Employee(id, firstname, lastname, age, gender, department, hireDate, salary, address, username, password, email, role);
                return e;
            }
            return null;
        }

        #endregion

    }
}
