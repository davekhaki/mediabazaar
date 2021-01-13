using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarOO.Entities
{
    public class Schedule
    {
        public int EmpId { get; set; }
        public string TimeOfDay { get; set; }

        private DateTime day;
        public DateTime Day
        {
            get { return this.day; }
            set
            {
                if (value.GetHashCode() == 0) { throw new ArgumentException("Day cannot be null."); }
                this.day = value;
            }
        }

        public Schedule(int id, DateTime day, string time)
        {
            this.EmpId = id;
            this.TimeOfDay = time;
            this.Day = day;
        }

        public Schedule(DateTime day, string time)
        {
            this.TimeOfDay = time;
            this.Day = day;
        }
    }
}