using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Media_Bazaar_Logic.Entities
{
    public abstract class User
    {
        #region Properties
        public int Id { get; set; }
        private string firstName;
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("First name is required"); }
                this.firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Last name is required"); }
                this.lastName = value;
            }
        }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int Salary { get; set; }

        public string Address { get; set; }

        private string username;
        public string Username
        {
            get => this.username;
            set
            {
                if(string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Username is required"); }
                this.username = value;
            }
        }
        private string password;
        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Password is required"); }
                this.password = value;
            }
        }
        private string email;
        public string Email
        {
            get => this.email;
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                { throw new FormatException("Email is not of a valid format"); }
                this.email = value;
            }
        }

        public string Role { get; set; }


        #endregion

        #region Constructors

        protected User(int id, string firstname, string lastname, int age, string gender, string department, DateTime hireDate, int salary, string address, string username, string password, string email, string role)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Gender = gender;
            this.Department = department;
            this.HireDate = hireDate;
            this.Salary = salary;
            this.Address = address;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;

        }
        //with end date included
        #endregion

        #region Methods

        #endregion
    }
}