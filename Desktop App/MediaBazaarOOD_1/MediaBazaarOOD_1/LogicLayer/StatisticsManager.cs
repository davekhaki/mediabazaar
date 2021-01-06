using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.LogicLayer
{
    public class StatisticsManager
    {
        private PersonStats personStats;
        //EmpStats empstats = new EmpStats();
        public StatisticsManager()
        {
            personStats = new PersonStats(StatisticsData.GetAllPersons());


        }
        public List<Person> GetAllPersons()
        {
            return StatisticsData.GetAllPersons();
        }


        public int GetAverageSalary()
        {
            return 1; 
        }

        public int GetNrPerGender(string gender)
        {
            return personStats.GetNrPerGender(gender);
        }
        public int GetNrPerDepartment(string departmentName)
        {
            return personStats.GetNrPerDepartment(departmentName);
        }
        public int GetNrPerRole(string role)
        {
            return personStats.GetNrPerRole(role);
        }
        public int GetTotalEmployees()
        {
            return personStats.TotalNumber();
        }


    }
}
