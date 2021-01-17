using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOO.Entities;
using MediaBazaarOO.Logic;

namespace MediaBazaar.Logic
{
    public class StatisticsManager
    {
        private List<Person> persons;

        private readonly PersonManager personManager = new PersonManager();

        public StatisticsManager()
        {
            persons = personManager.GetAllEmployees();
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

        public int GetTotalEmployees()
        {
            return persons.Count;
        }
    }
}
