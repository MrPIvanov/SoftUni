namespace _06_AddingNewAddressAndUpdatingEmpl
{
    using P02_DatabaseFirst.Data;
    using P02_DatabaseFirst.Data.Models;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext contex = new SoftUniContext())
            {
                var newAddress = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };

                var emploee = contex.Employees.FirstOrDefault(x => x.LastName == "Nakov");

                emploee.Address = newAddress;

                contex.SaveChanges();


                var emploeesToPrint = contex
                                            .Employees
                                            .OrderByDescending(x => x.AddressId)
                                            .Take(10)
                                            .Select(x => new
                                            {
                                                AddresText = x.Address.AddressText
                                            })
                                            .ToArray();

                using (StreamWriter sw = new StreamWriter("../../../../SoftUniJudgeResult.txt"))
                {
                    foreach (var e in emploeesToPrint)
                    {
                        sw.WriteLine($"{e.AddresText}");
                    }


                }
            }
        }
    }
}