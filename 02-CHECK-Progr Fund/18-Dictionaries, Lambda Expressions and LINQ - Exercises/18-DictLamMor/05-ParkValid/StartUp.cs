namespace _05_ParkValid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var database = new Dictionary<string, string>();
            int numberOfComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComands; i++)
            {
                var currentCommandArgs = Console.ReadLine().Split();
                var command = currentCommandArgs[0];
                var name = currentCommandArgs[1];



                if (command == "register")
                {
                    var plate = currentCommandArgs[2];

                    if (database.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {database[name]}");
                    }

                    else if (UnvalidePlateNumber(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }


                    else if (database.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }

                    else
                    {
                        Console.WriteLine($"{name} registered {plate} successfully");

                        database.Add(name, plate);
                    }


                }
                else
                {
                    if (!database.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {name} unregistered successfully");

                        database.Remove(name);
                    }

                }

            }

            foreach (var user in database)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }


        }

        private static bool UnvalidePlateNumber(string plate)
        {
            if (plate.Length!=8)
            {
                return true;
            }

            if (!(char.IsLetter(plate[0]) && char.IsLetter(plate[1]) && char.IsLetter(plate[6]) && char.IsLetter(plate[7])))
            {
                return true;

            }

            if (!(char.IsUpper(plate[0]) && char.IsUpper(plate[1]) && char.IsUpper(plate[6]) && char.IsUpper(plate[7])))
            {
                return true;
            }

            if (!(char.IsNumber(plate[2]) && char.IsNumber(plate[3]) && char.IsNumber(plate[4]) && char.IsNumber(plate[5])))
            {
                return true;
            }


            return false;
        }
    }
}