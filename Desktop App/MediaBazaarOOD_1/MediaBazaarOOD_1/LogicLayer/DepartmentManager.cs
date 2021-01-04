using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.LogicLayer
{
    public class DepartmentManager
    {
        List<Department> departments;

        public DepartmentManager()
        {
            departments = DepartmentData.GetAllDepartments();
        }
        public bool AddNewDepartment(Department department)
        {
            bool exist = false;
            try

            {
                foreach (Department d in departments)
                {
                    if (departments.Contains(d))
                    {
                        throw new ArgumentException("Department already exists");
                    }
                    else
                    {
                        DepartmentData.AddDepartment(d);
                        departments.Add(d);
                        exist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return exist;

        }

        public List<Department> GetAllDepartmentNames()
        {
            return DepartmentData.GetAllDepartments();
        }
    }
}
