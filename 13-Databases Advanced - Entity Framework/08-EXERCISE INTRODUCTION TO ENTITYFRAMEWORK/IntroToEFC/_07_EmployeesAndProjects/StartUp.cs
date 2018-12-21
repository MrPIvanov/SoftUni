namespace _07_EmployeesAndProjects
{
    using P02_DatabaseFirst.Data;
    using System.Globalization;
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
                                    .Where(x => x.EmployeesProjects
                                                        .Any(y => y.Project.StartDate.Year >= 2001 && y.Project.StartDate.Year <= 2003))
                                    .Select(x => new
                                    {
                                        EmployeeName = x.FirstName + " " + x.LastName,
                                        ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                                        Projects = x.EmployeesProjects.Select(z => new
                                        {
                                            ProjectName = z.Project.Name,
                                            StartDate = z.Project.StartDate,
                                            EndDate = z.Project.EndDate
                                        })
                                        .ToArray()
                                    })
                                    .Take(30)
                                    .ToArray();
                                    


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in employees)
                    {
                        sw.WriteLine($"{e.EmployeeName} - Manager: {e.ManagerName}");

                        foreach (var p in e.Projects)
                        {
                            sw.WriteLine($"--{p.ProjectName} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - " +
                                                 $"{p.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) ?? "not finished"}");
                        }
                    }


                }
            }
        }
    }
}