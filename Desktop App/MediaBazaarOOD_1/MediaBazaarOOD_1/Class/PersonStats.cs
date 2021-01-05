using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.Class
{
    public class PersonStats
    {
        private List<Person> persons;

        public PersonStats(List<Person> pers)
        {
            this.persons = pers;

        }
        public int TotalNumber()
        {
            return persons.Count;
        }


        public int GetNrPerGender(string gender)
        {
            int nr = 0;
            foreach (Person p in persons)
            {
                if (p.Gender == gender)
                {
                    nr++;
                }
            }

            return nr;
        }
        public int GetNrPerDepartment(string departmentName)
        {
            int nr = 0;
            foreach (Person p in persons)
            {
                if (p.DepartmentName == departmentName)
                {
                    nr++;
                }
            }

            return nr;
        }
        public int TotalNumberOfEmployees()
        {
            return this.persons.Count();
        }

        public int GetNrPerRole(string role)
        {
            int nr = 0;
            foreach (Person p in persons)
            {
                if (p.Role == role)
                {
                    nr++;
                }
            }
            return nr;
        }
        public int GetAverageSalary()
        {
            
                int numberOfPersons = persons.Count;
                int totalSalary = 0;
            foreach (Person p in persons)
            {
                totalSalary = totalSalary + p.Salary;
            }
                int result = totalSalary / numberOfPersons;
                return result;

        }



    }
}
