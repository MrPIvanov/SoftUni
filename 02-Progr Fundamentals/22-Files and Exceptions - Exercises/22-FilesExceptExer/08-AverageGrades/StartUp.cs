namespace _08_AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var studentsToPrint = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];

                var grades = new List<double>();

                for (int y = 1; y < input.Length; y++)
                {
                    grades.Add(double.Parse(input[y]));
                }

                var currentStudent = new Student(name,grades);

                if (currentStudent.Grades.Average() >= 5.00d)
                {
                    studentsToPrint.Add(currentStudent);
                }

            }

            foreach (var student in studentsToPrint.OrderBy(x=>x.Name).ThenByDescending(x=>x.Grades.Average()))
            {
                Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
            }


        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;

        }
    }
}