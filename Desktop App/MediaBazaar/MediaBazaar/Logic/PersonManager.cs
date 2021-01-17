using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaBazaar.Entities;
using MediaBazaar.Logic;
using MediaBazaarOO.Data;
using MediaBazaarOO.Entities;

namespace MediaBazaarOO.Logic
{
    public class PersonManager
    {
        private List<Person> persons;
        public PersonManager()
        {
            persons = PersonData.GetAllPersons();
        }

        public void RefreshEmployees()
        {
            persons = PersonData.GetAllPersons();
        }

        public List<Person> GetAllEmployees()
        {
            return persons;
        }

        public List<Person> GetEmployees()
        {
            var list = new List<Person>();
            foreach (var p in persons)
            {
                if(p.Role == "Employee") list.Add(p);
            }

            return list;
        }

        public void AddNewPerson(string firstname, string lastname, DateTime dob, string gender, string department, DateTime hireDate, int salary, string address, string role, string email)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            var p = new Person(firstname, lastname, age, gender, department, hireDate, salary, address, role);

            var username = firstname + persons[persons.Count - 1].Id;
            
            string password = PasswordManager.GeneratePassword();
            var hash = PasswordManager.HashPassword(password);

            PersonData.AddPerson(firstname, lastname, dob, gender, department, hireDate, salary, address, role, username, hash);
            persons.Add(p);

            MailManager.SendMail($"Welcome to Media Bazaar! \nHere are you Login Credentials: Username: {username}, Password: {password}", email, "Login Details");

        }

        public bool ValidLogin(string username, string password)
        {
            var hash = PasswordManager.HashPassword(password);
            var valid = PersonData.ValidateUsernamePassword(username, hash);
            switch (valid)
            {
                case 1: // 1 = login valid
                    return true;
                case 0: // 0 = login invalid
                    return false;
                case -1: // -1 = error
                    throw new Exception("Something went wrong.");
            }
            return false;
        }

        public int GetNewUser(string username) 
        {
            return PersonData.GetnewUser(username);
        }

        public void CompleteFirstLogin(string username)
        {
            PersonData.CompleteFirstLogin(username);
        }

        public string GetRole(string username) //gets a users role based on username
        {
            return PersonData.GetRole(username);
        }

        public int GetIdFromUsername(string username)
        {
            return PersonData.GetIdFromUsername(username);
        }

        public string GetFirstName(int id)
        {
            foreach(var p in persons)
            {
                if (p.Id == id)
                {
                    return p.FirstName;
                }
            }

            return null;
        }
        public string GetLastName(int id)
        {
            foreach (var p in persons)
            {
                if (p.Id == id)
                {
                    return p.LastName;
                }
            }

            return null;
        }

        public int GetIdFromFirstAndLastname(string first, string last)
        {
            // LINQ expression returns a person ID where first and lastname match
            foreach (var p in persons)
            {
                if (p.FirstName == first && p.LastName == last) return p.Id;
            }

            return 0;
            //return persons.Where(p => p.FirstName == first && p.LastName == last).Select(p => p.Id).First();
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            var hash = PasswordManager.HashPassword(oldPassword);
            var newHash = PasswordManager.HashPassword(newPassword);
            var valid = PersonData.ValidateUsernamePassword(username, hash);
            switch (valid)
            {
                case 1: // 1 = login valid
                    PersonData.ChangePassword(username, hash, newHash);
                    break;
                case 0: // 0 = login invalid
                    throw new Exception("Old password incorrect");
                case -1: // -1 = error
                    throw new Exception("Something went wrong.");
            }
        }

        public void UpdatePreference(string username, bool weekends, bool morning, bool afternoon, bool evening)
        {
            var userId = GetIdFromUsername(username);
            foreach (var p in persons)
            {
                if (p.Id == userId)
                {
                    p.Preference = new SchedulePreference(weekends, morning, afternoon, evening, new List<string>());
                    PersonData.UpdatePreference(userId, p.Preference);
                }
            }
        }

        public List<bool> GetPreference(int id)
        {
            return PersonData.GetPreference(id);
        }

        public void EditEmployeeInfo(int id, string firstName, string lastName, DateTime dob, string gender, string dName, DateTime hireDate, int salary, string address, string role)
        {
            PersonData.EditPersonDetails(id, firstName, lastName, dob, gender, dName, hireDate, salary, address, role);
        }

        public DateTime GetDob(int id)
        {
            return PersonData.GetDob(id);
        }
    }
}
