namespace _08_AddressesByTown
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

                var addresses = contex
                                      .Addresses
                                      .Select(x => new
                                      {
                                          AddressText = x.AddressText,
                                          TownName = x.Town.Name,
                                          EmployeeCount = x.Employees.Count
                                      })
                                      .OrderByDescending(x => x.EmployeeCount)
                                      .ThenBy(x => x.TownName)
                                      .ThenBy(x => x.AddressText)
                                      .Take(10)
                                      .ToArray();

                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var a in addresses)
                    {
                        sw.WriteLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
                    }


                }
            }
        }
    }
}