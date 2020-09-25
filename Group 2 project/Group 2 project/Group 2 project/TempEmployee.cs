using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2_project
{
    public class TempEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender{ get; set; }
        public int DepartmentId { get; set; }
        public string HireDate { get; set; }
        public int Salary { get; set; }
        public string Adress { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return ($"ID: {Id}, First Name: {FirstName}, Last Name: ${LastName}, Age: {Age}, Gender: {Gender}, Department ID: {DepartmentId}, Hire Date: {HireDate}, Salary: {Salary}, Adress: {Adress}, Role: {Role}");
        }
    }
}
