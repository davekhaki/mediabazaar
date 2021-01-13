using System;
using System.Collections.Generic;
using System.Text;
using MediaBazaarOO.Entities;

namespace MediaBazaarOO.Logic.Interfaces
{
    public class ScheduleComparer : IEqualityComparer<Schedule>
    {
        //some schedules in the database a duplicates, to avoid multiple of the same schedules showing up on timetables
        //this class will compare and be used to hide duplicates

        public bool Equals(Schedule x, Schedule y)
        {
            return x.Day == y.Day &&
                   x.EmpId == y.EmpId &&
                   x.TimeOfDay == y.TimeOfDay;
        }

        public int GetHashCode(Schedule obj)
        {
            return obj.Day.GetHashCode() ^
                   obj.TimeOfDay.GetHashCode() ^
                   obj.EmpId.GetHashCode();

        }
    }
}
