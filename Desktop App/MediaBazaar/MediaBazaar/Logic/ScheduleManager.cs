using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaar.Data;
using MediaBazaarOO.Entities;
using MediaBazaarOO.Logic.Interfaces;

namespace MediaBazaar.Logic
{
    public class ScheduleManager
    {
        private readonly List<Schedule> schedules;

        public ScheduleManager()
        {
            schedules = ScheduleData.GetAllSchedules();
        }

        public List<Schedule> GetSchedulesForDay(DateTime date, int empId) //schedules to show when employees select a date on the calendar
        {
            return schedules.Where(s => s.Day == date && s.EmpId == empId).Distinct(new ScheduleComparer()).ToList();
            //distinct makes use of comparer to remove duplicates such as double morning shift
        }

        public void AddSchedule(DateTime day, string time, int employeeId)
        {
            try
            {
                var s = new Schedule(employeeId, day, time);
                if (!schedules.Contains(s))
                    schedules.Add(s); //adds it to the local list
                ScheduleData.AddSchedule(s); //adds it to the database
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public List<Schedule> GetUpcomingSchedules(int employeeId)
        {
            return schedules.Where(s => s.EmpId == employeeId).ToList();
            //return schedules.Where(s => s.EmpId == employeeId && s.Day >= DateTime.Now).ToList();
        }

        public List<Schedule> GetOverview(DateTime day)
        {
            var list = new List<Schedule>();
            foreach (var s in schedules)
            {
                if(s.Day == day.Date) list.Add(s);
            }

            return list;
        }
    }
}
