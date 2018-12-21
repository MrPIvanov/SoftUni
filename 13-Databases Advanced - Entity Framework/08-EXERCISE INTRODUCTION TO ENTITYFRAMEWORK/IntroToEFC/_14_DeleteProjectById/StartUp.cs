namespace _14_DeleteProjectById
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
                var projectsToDelete = contex
                                            .EmployeesProjects
                                            .Where(x => x.ProjectId ==2)
                                            .ToArray();

                contex.EmployeesProjects.RemoveRange(projectsToDelete);

                var projectToDelete = contex.Projects.Find(2);

                contex.Projects.Remove(projectToDelete);

                contex.SaveChanges();


                var projectsToPrint = contex
                                            .Projects
                                            .Select(x => new
                                            {
                                                Name = x.Name
                                            })
                                            .Take(10)
                                            .ToArray();

                


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {

                    foreach (var p in projectsToPrint)
                    {
                        sw.WriteLine($"{p.Name}");
                    }

                }
            }
        }
    }
}