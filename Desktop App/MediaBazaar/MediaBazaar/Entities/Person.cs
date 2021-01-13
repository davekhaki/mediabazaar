using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarOO.Entities
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string gender;
        private string departentName;
        private DateTime hireDate;
        //private DateTime endDate;
        private int salary;
        private string address;
        private string role;
        //private string email;

        public Person(string givenFirstName, string givenLastName, int givenAge, string givenGender, string givenDname, DateTime givenHireDate, int givenSalary, string givenAddress, string givenRole)
        {
            this.FirstName = givenFirstName;
            this.LastName = givenLastName;
            this.Age = givenAge;
            this.Gender = givenGender;
            this.DepartmentName = givenDname;
            this.HireDate = givenHireDate;
            // this.EndDate = givenENdDate;
            this.Salary = givenSalary;
            this.Address = givenAddress;
            this.Role = givenRole;
            this.Preference = new SchedulePreference(true, true, true, true, new List<string>());
        }

        public int Id { get; set; }

        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("First name is required"); }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Last name is required"); }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }

        }
        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }

        }
        public string DepartmentName
        {
            get { return this.departentName; }
            set { this.departentName = value; }

        }
        public DateTime HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }

        }
        public DateTime? EndDate { get; set; }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }

        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }

        }
        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public SchedulePreference Preference { get; set; }
        public override string ToString()
        {
            return this.Id + this.firstName + this.lastName + this.age + this.gender + this.hireDate + this.salary + this.address + this.role;
        }
    }
}
