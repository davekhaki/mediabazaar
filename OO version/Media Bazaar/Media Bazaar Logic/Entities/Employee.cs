using System;
using System.Collections.Generic;

namespace Media_Bazaar_Logic.Entities
{
    public class Employee : User
    {
        #region Properties
        //private List<Schedule> schedules;
        #endregion

        #region Constructors
        public Employee(int id, string firstname, string lastname, int age, string gender, string department, DateTime hireDate, int salary, string address, string username, string password, string email, string role): base(id, firstname, lastname, age, gender, department, hireDate, salary, address, username, password, email, role)
        {
            
        }

        #endregion
    }
}
