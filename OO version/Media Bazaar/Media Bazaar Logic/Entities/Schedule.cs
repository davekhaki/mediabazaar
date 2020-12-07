using System;
using System.Collections.Generic;
using System.Text;

namespace Media_Bazaar_Logic.Entities
{
    public class Schedule
    {
        public int EmpId { get; set; }
        private string timeOfDay;
        public string TimeofDay
        {
            get { return this.timeOfDay; }
            set
            {
                
                this.timeOfDay = value;
            }
        }

        private DateTime day;
        public DateTime Day
        {
            get { return this.day; }
            set
            {
                if(value.GetHashCode() == 0) { throw new ArgumentException("Day cannot be null."); }
                this.day = value;
            }
        }

        public Schedule(int id, string time, DateTime day)
        {
            this.EmpId = id;
            this.TimeofDay = time;
            this.Day = day;
        }
    }
}
