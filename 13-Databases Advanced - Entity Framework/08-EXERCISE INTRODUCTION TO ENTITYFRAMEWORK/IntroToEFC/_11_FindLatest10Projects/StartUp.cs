namespace _11_FindLatest10Projects
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
                var projects = contex
                                    .Projects
                                    .OrderByDescending(x => x.StartDate)
                                    .Take(10)
                                    .ToArray()
                                    .Select(x => new
                                    {
                                        ProjectName = x.Name,
                                        Description = x.Description,
                                        StartDate = x.StartDate
                                    })
                                    .OrderBy(x => x.ProjectName)
                                    .ToArray();


                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var p in projects)
                    {
                        sw.WriteLine($"{p.ProjectName}");
                        sw.WriteLine($"{p.Description}");
                        sw.WriteLine($"{p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                    }


                }
            }
        }
    }
}