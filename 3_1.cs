using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task3_1
    {
        public void Main3_1()
        {
            List<Person> persons = new List<Person>();

            Person person1 = new Person { name = "John", age = 23, PhoneNumbers = new List<string>{ "067-905-80-67", "093-234-60-57" } };
            Person person2 = new Person { name = "Jack", age = 56, PhoneNumbers = new List<string> { "067-505-97-61", "093-254-30-37" } };
            Person person3 = new Person { name = "Peter", age = 36, PhoneNumbers = new List<string> { "067-805-77-60", "093-244-20-97" } };
            Person person4 = new Person { name = "Steve", age = 21, PhoneNumbers = new List<string> { "067-965-67-62", "093-294-67-67" } };
            Person person5 = new Person { name = "Margaret", age = 18, PhoneNumbers = new List<string> { "067-909-27-66", "093-222-91-47" } };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            persons.Add(person5);

            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine("{0}: Name: {1}, Age: {2}", i + 1, persons[i].name, persons[i].age);
            }
        }
    }
}

class Person
{
    public string name { get; set; }
    public int age { get; set; }
    public IEnumerable<string> PhoneNumbers { get; set; }
}