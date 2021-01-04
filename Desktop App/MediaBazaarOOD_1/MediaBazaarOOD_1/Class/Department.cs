using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.Class
{
    public class Department
    {
        //fields
        private int deptId;
        private string deptName;
        public Department(int id, string dName)
        {
            this.deptId = id;
            this.deptName = dName;

        }

        public int DeptId
        {
            get { return this.deptId; }
            set { this.deptId = value; }
        }
        public string DeptName
        {
            get { return this.deptName; }
            set { this.DeptName = value; }
        }
    }
}
