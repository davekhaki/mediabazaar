using System;
using System.Collections.Generic;
using System.Text;

namespace Media_Bazaar_Logic.Entities
{
    public class Admin : User
    {
        public Admin(int id, string firstname, string lastname, int age, string gender, string department, DateTime hireDate, int salary, string address, string username, string password, string email, string role) : base(id, firstname, lastname, age, gender, department, hireDate, salary, address, username, password, email, role)
        {
        }
    }
}
