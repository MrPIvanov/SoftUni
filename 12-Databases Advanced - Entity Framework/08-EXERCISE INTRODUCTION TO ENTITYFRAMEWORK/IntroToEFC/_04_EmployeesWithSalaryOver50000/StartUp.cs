namespace _04_EmployeesWithSalaryOver50000
{
    using P02_DatabaseFirst.Data;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext contex = new SoftUniContext())
            {
                var emploees = contex
                                    .Employees
                                    .Where(x => x.Salary > 50000)
                                    .Select(x => new
                                    {
                                        FirstName = x.FirstName
                                    })
                                    .OrderBy(x => x.FirstName)
                                    .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in emploees)
                    {
                        sw.WriteLine($"{e.FirstName}");
                    }


                }
            }
        }
    }
}