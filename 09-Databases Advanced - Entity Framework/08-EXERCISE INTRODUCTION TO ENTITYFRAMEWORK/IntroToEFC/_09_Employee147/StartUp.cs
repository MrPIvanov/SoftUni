namespace _09_Employee147
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
                var employee = contex
                                    .Employees
                                    .SingleOrDefault(x => x.EmployeeId == 147);

                var projects = contex
                                    .Projects
                                    .Where(x => x.EmployeesProjects.Any(y => y.EmployeeId == 147))
                                    .OrderBy(x => x.Name)
                                    .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    sw.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

                    foreach (var p in projects)
                    {
                        sw.WriteLine($"{p.Name}");
                    }


                }
            }
        }
    }
}