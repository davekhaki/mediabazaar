using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaar.Data;
using MediaBazaar.Entities;
using MediaBazaarOO.Entities;
using MediaBazaarOO.Logic;

namespace MediaBazaar.Logic
{
    public class AutoScheduleAlgorithm
    {
        private readonly PersonManager personManager = new PersonManager();
        private List<Person> employees; //employees to be auto scheduled
        private List<Schedule> schedules; //schedules to be filled by employees
        private List<DateTime> holidays; //array for holidays to filter schedules with
        private DateTime start; //start of period for auto scheduling
        private DateTime end; //end of auto scheduling time period

        public AutoScheduleAlgorithm(DateTime start, DateTime end)
        {
            this.employees = personManager.GetEmployees();
            this.start = start;
            this.end = end;
            schedules = GenerateSchedules();
            this.holidays = GetHolidays();
        }

        public void AssignSchedules()
        {
            var counter = 0;
            var counter2 = 0;

            foreach (var s in schedules)
            {
                if (holidays.Contains(s.Day)) // checks if the day is a holiday
                {
                    continue;
                }

                if (s.Day.DayOfWeek == DayOfWeek.Saturday || s.Day.DayOfWeek == DayOfWeek.Sunday) // no work on the weekends
                {
                    continue;
                }

                //if (s.Employees.Count > 4) // makes it so 5 is the limit per schedule
                //{
                //    continue;
                //} cannot use because this schedule does not have a list therefore the count cannot be checked this way

                counter2 += 5;
                for (int i = counter; i < counter2; i++)
                {
                    if (counter >= 0 && counter < employees.Count)
                    {
                        employees[i].Id = personManager.GetIdFromFirstAndLastname(employees[i].FirstName, employees[i].LastName);

                        if (employees[i].Preference.WorkMorning == false && s.TimeOfDay == "Morning" || employees[i].Preference.WorkEvening == false && s.TimeOfDay == "Evening")
                        {
                            continue; //continue = go next in foreach loop
                        }

                        if (employees[i].Preference.ExcludedDays.Contains(s.Day.DayOfWeek.ToString()))
                        {
                            continue;
                        }

                        s.EmpId = employees[i].Id; //adds employee id to the schedule (assigning)
                        //send to database after assigning
                        ScheduleData.AddSchedule(s);
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        counter2 = 5;
                        continue;
                    }
                    
                }

                /*foreach (var e in employees.Take(5))
                {
                    if (counter != counter2)
                    {
                        counter2++;
                        continue;
                    }

                    e.Id = personManager.GetIdFromFirstAndLastname(e.FirstName, e.LastName);
                    if (e.Preference.WorkMorning == false && s.TimeOfDay == "Morning" || e.Preference.WorkEvening == false && s.TimeOfDay == "Evening")
                    {
                        continue; //continue = go next in foreach loop
                    }

                    if (e.Preference.ExcludedDays.Contains(s.Day.DayOfWeek.ToString()))
                    {
                        continue;
                    }

                    s.EmpId = e.Id; //adds employee id to the schedule (assigning)
                    //send to database after assigning
                    ScheduleData.AddSchedule(s);
                }*/

            }
        }


        public List<Schedule> GenerateSchedules()
        {
            var list = new List<Schedule>();
            foreach (var day in EachDay(this.start, this.end))
            {
                var morning = new Schedule(day, "Morning");
                var afternoon = new Schedule(day, "Afternoon");
                var evening = new Schedule(day, "Evening");

                list.Add(morning);
                list.Add(afternoon);
                list.Add(evening);
            }
            return list;
        }

        public List<DateTime> GetHolidays()
        {
            List<DateTime> temp = new List<DateTime>();
            temp.Add(new DateTime(2020, 12, 25));
            temp.Add(new DateTime(2020, 12, 30));
            temp.Add(new DateTime(2020, 12, 31));
            return temp;
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
