namespace _12_IncreaseSalaries
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
                var employeesToIncrease = contex
                                                .Employees
                                                .Where(x => x.Department.Name == "Engineering"
                                                         || x.Department.Name == "Tool Design"
                                                         || x.Department.Name == "Marketing"
                                                         || x.Department.Name == "Information Services")
                                                .ToArray();

                foreach (var e in employeesToIncrease)
                {
                    e.Salary *= 1.12m;
                }

                contex.SaveChanges();

                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {

                    foreach (var e in employeesToIncrease.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:F2})");
                    }

                }
            }
        }
    }
}