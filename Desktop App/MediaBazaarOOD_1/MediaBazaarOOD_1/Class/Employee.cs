using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.Class
{
    public class Employee:Person
    {
        public Employee(string givenFirstName, string givenLastName, int givenAge, string givenGender, string givenDname, DateTime givenHireDate, int givenSalary, string givenAddress, string givenRole) : base(givenFirstName, givenLastName, givenAge, givenGender, givenDname, givenHireDate, givenSalary, givenAddress, givenRole)
        {

        }

        //public Employee(int id, string givenFirstName, string givenLastName, int givenAge, string givenGender, string givenDname, DateTime givenHireDate, DateTime givenENdDate, int givenSalary, string givenAddress, string givenRole) : base(givenFirstName, givenLastName, givenAge, givenGender, givenDname, givenHireDate, givenSalary, givenAddress, givenRole)
        //{
        //    base.Id++;
        //}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
