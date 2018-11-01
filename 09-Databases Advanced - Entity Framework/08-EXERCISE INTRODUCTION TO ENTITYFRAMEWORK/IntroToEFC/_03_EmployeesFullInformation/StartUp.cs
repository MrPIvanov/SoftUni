namespace _03_EmployeesFullInformation
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
                                    .OrderBy(x => x.EmployeeId)
                                    .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    MiddleName = x.MiddleName,
                    JobTitle = x.JobTitle,
                    Salary = x.Salary

                }).ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in emploees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F2}");
                    }

                }
            }
        }
    }
}