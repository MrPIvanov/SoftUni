using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            var studentArgs = Console.ReadLine().Split();
            var workerArgs = Console.ReadLine().Split();

            var studentFirstName = studentArgs[0];
            var studentLastName = studentArgs[1];
            var studentFacultyNumber = studentArgs[2];

            var workerFirstName = workerArgs[0];
            var workerLastName = workerArgs[1];
            var workerWeekSalary = decimal.Parse(workerArgs[2]);
            var workerWorkingHoursPerDay = decimal.Parse(workerArgs[3]);

            var student = new Student(studentFirstName,studentLastName,studentFacultyNumber);
            var worker = new Worker(workerFirstName,workerLastName,workerWeekSalary,workerWorkingHoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}