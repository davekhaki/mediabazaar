using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2_project
{
    public class Shift
    {
        private int EmpId { get; set; }
        public string TimeOfDay { get; set; }
        public DateTime Day { get; set; }

        public override string ToString()
        {
            return $"Time: {TimeOfDay} , Date: {Day}";
        }
    }
}
