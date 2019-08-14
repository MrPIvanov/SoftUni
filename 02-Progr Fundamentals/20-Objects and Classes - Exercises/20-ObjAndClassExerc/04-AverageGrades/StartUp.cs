using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AverageGrades
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var listOfStudents = new List<KeyValuePair<string, double>>();


            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var currentStudent = new Student() {Name=input[0], Grades=input.Skip(1).Select(double.Parse).ToArray() };
                currentStudent.AverageGrade = currentStudent.Grades.Average();


                listOfStudents.Add(new KeyValuePair<string, double>(currentStudent.Name, currentStudent.AverageGrade));
            }
            foreach (var student in listOfStudents.OrderBy(x=>x.Key).ThenByDescending(x=>x.Value).Where(x =>x.Value>=5.00))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");

            }

        }
    }
    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }
    }
}