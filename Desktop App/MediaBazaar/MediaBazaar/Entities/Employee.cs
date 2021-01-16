using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOO.Entities;

namespace MediaBazaar.Entities
{
    public class Employee : Person
    {
        public Employee(string givenFirstName, string givenLastName, int givenAge, string givenGender, string givenDname, DateTime givenHireDate, int givenSalary, string givenAddress, string givenRole) : base(givenFirstName, givenLastName, givenAge, givenGender, givenDname, givenHireDate, givenSalary, givenAddress, givenRole)
        {

        }
    }
}
