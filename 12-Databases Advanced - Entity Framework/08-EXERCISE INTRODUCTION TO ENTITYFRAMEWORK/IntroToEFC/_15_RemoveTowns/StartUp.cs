namespace _15_RemoveTowns
{
    using P02_DatabaseFirst.Data;
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext contex = new SoftUniContext())
            {
                var townToDelete = Console.ReadLine();

                var numberOfAddresses = contex.Addresses.Where(x => x.Town.Name == townToDelete).Count();


                var allAddressesToDelete = contex.Addresses.Where(x => x.Town.Name == townToDelete).ToArray();

                var employeesUsingAddresses = contex
                                                .Employees
                                                .Where(x => allAddressesToDelete.Any(s => s == x.Address))
                                                .ToArray();

                foreach (var e in employeesUsingAddresses)
                {
                    e.AddressId = null;
                }


                contex.Addresses.RemoveRange(allAddressesToDelete);

                var townToRemove = contex.Towns.SingleOrDefault(x => x.Name == townToDelete);

                contex.Towns.Remove(townToRemove);

                contex.SaveChanges();

                Console.WriteLine($"{numberOfAddresses} addresses in {townToDelete} were deleted");
            }
        }
    }
}