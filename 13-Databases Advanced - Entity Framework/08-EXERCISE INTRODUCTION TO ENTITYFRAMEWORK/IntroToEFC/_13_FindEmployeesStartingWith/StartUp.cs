namespace _13_FindEmployeesStartingWith
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
                var employees = contex
                                      .Employees
                                      .Where(x => x.FirstName.StartsWith("Sa"))
                                      .OrderBy(x => x.FirstName)
                                      .ThenBy(x => x.LastName)
                                      .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})");
                    }


                }
            }
        }
    }
}