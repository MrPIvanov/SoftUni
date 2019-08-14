namespace _05_EmployeesFromResearchAndDevelop
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
                                    .Where(x => x.Department.Name == "Research and Development")
                                    .Select(x => new
                                    {
                                        FirstName = x.FirstName,
                                        LastName = x.LastName,
                                        DepartmentName = x.Department.Name,
                                        Salary = x.Salary
                                    })
                                    .OrderBy(x => x.Salary)
                                    .ThenByDescending(x => x.FirstName)
                                    .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in emploees)
                    {
                        sw.WriteLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:F2}");
                    }


                }
            }
        }
    }
}