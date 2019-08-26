using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task3_2
    {
        public void Main3_2()
        {
            List<Person3_2> persons = new List<Person3_2>();
            List<Person3_2> persons2 = new List<Person3_2>();

            Person3_2 person1 = new Person3_2 { name = "John", age = 23, PhoneNumbers = new List<string> { "067-905-80-67", "093-234-60-57" } };
            Person3_2 person2 = new Person3_2 { name = "Jack", age = 56, PhoneNumbers = new List<string> { "067-505-97-61", "093-254-30-37" } };
            Person3_2 person3 = new Person3_2 { name = "Peter", age = 36, PhoneNumbers = new List<string> { "067-805-77-60", "093-244-20-97" } };
            Person3_2 person4 = new Person3_2 { name = "Steve", age = 21, PhoneNumbers = new List<string> { "067-965-67-62", "093-294-67-67" } };
            Person3_2 person5 = new Person3_2 { name = "Margaret", age = 18, PhoneNumbers = new List<string> { "067-909-27-66", "093-222-91-47" } };

            Person3_2 person6 = new Person3_2 { name = "Robert", age = 18, PhoneNumbers = new List<string> { "067-109-24-66", "093-522-71-07" } };
            Person3_2 person7 = new Person3_2 { name = "Susan", age = 18, PhoneNumbers = new List<string> { "067-909-27-66", "093-992-94-57" } };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            persons.Add(person5);

            persons2.Add(person6);
            persons2.Add(person7);

            persons.AddRange(persons2);

            foreach (Person3_2 prs in persons)
            {
                int i = 1;
                Console.WriteLine("Name:{0}", prs.name);
                foreach (string s in prs.PhoneNumbers)
                {
                    Console.WriteLine("Phone number {0}: {1}", i,s); i++;
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}

class Person3_2
{
    public string name { get; set; }
    public int age { get; set; }
    public IEnumerable<string> PhoneNumbers { get; set; }
}