using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarOO.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string ProductName { get; set; }

        public Request(int id, string type, string status, string name)
        {
            Id = id;
            Type = type;
            Status = status;
            ProductName = name;
        }
    }
}
