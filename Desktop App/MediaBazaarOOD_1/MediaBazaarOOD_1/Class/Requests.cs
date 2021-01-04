using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.Class
{
    public class Requests
    {
       private string productName;
        private int quantity;
        private int empId;
        private string status;
        private int requestID;
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int EmpId
        {
            get { return this.empId; }
            set { this.empId = value; }
        }
        public int RequestID
        {
            get { return this.requestID; }
            set { this.requestID = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }


        public Requests(string pName)
        {
            this.ProductName = pName;
          

        }

        public Requests(string pName, int empId, string status)
        {
            this.ProductName = pName;
            this.EmpId = empId;
            this.Status = status;
        }

        public Requests() { 
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
