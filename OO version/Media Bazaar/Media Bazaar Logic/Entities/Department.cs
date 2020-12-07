using System;
using System.Collections.Generic;
using System.Text;

namespace Media_Bazaar_Logic.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
