using System;
using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> Repo { get; set; }

    public StudentSystem()
    {
        Repo = new Dictionary<string, Student>();
    }

    public void Create(string[] args)
    {
        var name = args[1];
        var age = int.Parse(args[2]);
        var grade = double.Parse(args[3]);
        if (!Repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            Repo[name] = student;
        }
    }
    public void Show(string[] args)
    {
        var name = args[1];

        if (Repo.ContainsKey(name))
        {
            var student = Repo[name];

            Console.WriteLine(student);
        }

    }
}