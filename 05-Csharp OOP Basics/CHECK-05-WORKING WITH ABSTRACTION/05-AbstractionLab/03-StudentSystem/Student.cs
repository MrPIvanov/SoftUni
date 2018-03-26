using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
    

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public override string ToString()
    {
        string gradeResult;

        if (Grade >= 5.00)
        {
            gradeResult = "Excellent student.";
        }
        else if (Grade < 5.00 && Grade >= 3.50)
        {
            gradeResult = "Average student.";
        }
        else
        {
            gradeResult= "Very nice person.";
        }

        return $"{Name} is {Age} years old. {gradeResult}";

    }
}