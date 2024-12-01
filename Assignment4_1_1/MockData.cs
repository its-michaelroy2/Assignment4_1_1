using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1_1
{
    internal class MockData
    {



        // Populate the collections with mock data
        // Collection holding the Student data used by the prototype application
        //Key of type string & Value of Object type Person
        public static Dictionary<string, Person> CreateData()
        {
            Dictionary<string, Person> Persons = new Dictionary<string, Person>();

            Person person1 = new Person() { FirstName = "Kevin", LastName = "Liu", MobilePhone = "916-555-1234", WorkPhone = "916-555-4567", Address = "Sequim WA" };
            Persons.Add(person1.FullName, person1);

            Person person2 = new Person() { FirstName = "James", LastName = "Smith", MobilePhone = "916-555-7890", WorkPhone = "916-555-6543", Address = "Seattle WA" };
            Persons.Add(person2.FullName, person2);



            return Persons;

        }
    }
}