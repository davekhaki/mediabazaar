using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarOO.Entities
{
    public class SchedulePreference
    {
        public bool WorkWeekends { get; set; }
        public bool WorkMorning { get; set; }
        public bool WorkAfternoon { get; set; }
        public bool WorkEvening { get; set; }

        public List<string> ExcludedDays { get; set; }

        public SchedulePreference(bool weekend, bool morning, bool afternoon, bool evening, List<string> excluded)
        {
            WorkWeekends = weekend;
            WorkMorning = morning;
            WorkAfternoon = afternoon;
            WorkEvening = evening;
            ExcludedDays = excluded;
        }

        public override string ToString()
        {
            return $"Morning: {WorkMorning}, Afternoon: {WorkAfternoon}, Evening: {WorkEvening}";
        }
    }
}
