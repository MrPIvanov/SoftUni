namespace _10_DepartmentsWithMoreThan5Employ
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
                var departments = contex
                                        .Departments
                                        .Where(x => x.Employees.Count > 5)
                                        .Select(x => new
                                        {
                                            DepartmentName = x.Name,
                                            ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                                            EmployeeCount = x.Employees.Count,
                                            Employees = x.Employees
                                        })
                                        .OrderBy(x => x.EmployeeCount)
                                        .ThenBy(x => x.DepartmentName)
                                        .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var d in departments)
                    {
                        sw.WriteLine($"{d.DepartmentName} - {d.ManagerName}");

                        foreach (var e in d.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                        {
                            sw.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                        }

                        sw.WriteLine($"----------");
                    }


                }
            }
        }
    }
}