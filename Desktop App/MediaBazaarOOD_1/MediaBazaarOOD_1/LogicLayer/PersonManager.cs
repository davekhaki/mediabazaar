using MediaBazaarOOD_1.Class;
using MediaBazaarOOD_1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.LogicLayer
{
    public class PersonManager
    {

        //all the employee related data access
        List<Person> persons;
        public PersonManager()
        {
            persons = PersonData.GetAllPersons();
        }

        public void AddNewPerson(Person person)
        {
            PersonData.AddPerson(person);
            persons.Add(person);
            //    bool exist = false;
            //    try

            //    {
            //        foreach (Person p in persons)
            //        {
            //            if (persons.Contains(p))
            //            {
            //                throw new ArgumentException("Person already exists");
            //            }
            //            else
            //            {
            //                PersonData.AddPerson(person);
            //                persons.Add(person);
            //                exist = true;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //       MessageBox.Show(ex.ToString());
            //    }
            //    return exist;
        }

        public List<Person> GetAllPersons()
        {
            return PersonData.GetAllPersons();
        }
        public Person GetPerson(int id)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Id == id)
                {
                    return persons[i];
                }
            }

            return null;
        }

        public List<int> GetAllIds()
        {
            return PersonData.GetAllIds();
        }
        public void EditEmployeeInfo(string firstName, string lastName, int age, string gender, string dName, DateTime hireDate, int salary, string address, string role)
        {
            //this method edits any of the persons details.....
            PersonData.EditPersonDetails(firstName, lastName, age, gender, dName, hireDate, salary, address, role);
        }



    }
}
