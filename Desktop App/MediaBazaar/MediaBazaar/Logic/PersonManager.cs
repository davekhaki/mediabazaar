using System;
using System.Collections.Generic;
using System.Text;
using MediaBazaarOO.Data;
using MediaBazaarOO.Entities;

namespace MediaBazaarOO.Logic
{
    public class PersonManager
    {
        private readonly List<Person> persons;
        public PersonManager()
        {
            persons = PersonData.GetAllPersons();
        }

        public List<Person> GetAllEmployees()
        {
            return persons;
        }

        public List<Person> GetEmployees()
        {
            var list = new List<Person>();
            foreach (var p in persons)
            {
                if(p.Role == "Employee") list.Add(p);
            }

            return list;
        }

        public void AddNewPerson(Person person)
        {
            //bool exist = false;
            try

            {
                //foreach (Person p in persons)
                //{
                /*if (persons.Contains(p))
                {
                    throw new ArgumentException("Person already exists");
                }*/
                PersonData.AddPerson(person);
                persons.Add(person);
                //exist = true;
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            //return exist;
        }

        public bool ValidLogin(string username, string password)
        {

            var valid = PersonData.ValidateUsernamePassword(username, password);
            switch (valid)
            {
                case 1: // 1 = login valid
                    return true;
                case 0: // 0 = login invalid
                    return false;
                case -1: // -1 = error
                    throw new Exception("Something went wrong.");
            }
            return false;
        }

        public string GetRole(string username) //gets a users role based on username
        {
            return PersonData.GetRole(username);
        }

        public int GetIdFromUsername(string username)
        {
            return PersonData.GetIdFromUsername(username);
        }

        public int GetIdFromFirstAndLastname(string first, string last)
        {
            // LINQ expression returns a person ID where first and lastname match
            foreach (var p in persons)
            {
                if (p.FirstName == first && p.LastName == last) return p.Id;
            }

            return 0;
            //return persons.Where(p => p.FirstName == first && p.LastName == last).Select(p => p.Id).First();
        }

        public void ChangePassword(string username, string oldPassword, string newPassword)
        {
            var valid = PersonData.ValidateUsernamePassword(username, oldPassword);
            switch (valid)
            {
                case 1: // 1 = login valid
                    PersonData.ChangePassword(username, oldPassword, newPassword);
                    break;
                case 0: // 0 = login invalid
                    throw new Exception("Old password incorrect");
                case -1: // -1 = error
                    throw new Exception("Something went wrong.");
            }
        }

        public void UpdatePreference(string username, bool weekends, bool morning, bool afternoon, bool evening)
        {
            var userId = GetIdFromUsername(username);
            foreach (var p in persons)
            {
                if (p.Id == userId)
                {
                    p.Preference = new SchedulePreference(weekends, morning, afternoon, evening, new List<string>());
                    PersonData.UpdatePreference(userId, p.Preference);
                }
            }
        }
    }
}
