using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_OrderByAge
{
    public class StartUp
    {
        public static void Main()
        {
            var allPersons = new List<Person>();
            string input;
            while ((input = Console.ReadLine())!= "End")
            {
                allPersons.Add(new Person(input));

            }

            var sortedPersons = allPersons.OrderBy(x => x.Age).ToList();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine(person);
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string input)
        {
            var inputArgs = input.Split();
            Name = inputArgs[0];
            ID = inputArgs[1];
            Age = int.Parse(inputArgs[2]);

        }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}