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

        public bool AddNewPerson(Person person)
        {
            bool exist = false;
            try

            {
                foreach (Person p in persons)
                {
                    if (persons.Contains(p))
                    {
                        throw new ArgumentException("Person already exists");
                    }
                    else
                    {
                        PersonData.AddPerson(person);
                        persons.Add(person);
                        exist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return exist;
        }

        public List<Person> GetAllPersons()
        {
            return PersonData.GetAllPersons();
        }


    }
}
