using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var numberOfCommands = int.Parse(Console.ReadLine());
        var allPets = new List<Pet>();
        var allClinics = new List<Clinic>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            var tokens = Console.ReadLine().Split();

            var command = tokens[0];

            switch (command)
            {
                case "Create":
                    if (tokens[1]=="Pet")
                    {
                        var currentPet = new Pet(tokens[2], int.Parse(tokens[3]), tokens[4]);
                        allPets.Add(currentPet);
                    }
                    else
                    {
                        try
                        {
                            var currentClinicToAdd = new Clinic(tokens[2], int.Parse(tokens[3]));
                            allClinics.Add(currentClinicToAdd);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;

                case "Add":

                    try
                    {
                        var clinicName = tokens[2];
                        var petName = tokens[1];

                        var clinic = allClinics.Where(x => x.Name == clinicName).FirstOrDefault();
                        Console.WriteLine(clinic.TryAddPet(allPets, petName));
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case "Release":
                    var clinicNameForRelease = tokens[1];
                    var currentClinic = allClinics.Where(x => x.Name == clinicNameForRelease).FirstOrDefault();

                    Console.WriteLine(currentClinic.ReleasePet());
                    break;

                case "HasEmptyRooms":
                    var clinicNameForRooms = tokens[1];
                    var currentClinicForRooms = allClinics.Where(x => x.Name == clinicNameForRooms).FirstOrDefault();

                    Console.WriteLine(currentClinicForRooms.CheckForRoom());
                    break;

                case "Print":

                    if (tokens.Length==2)
                    {
                        var clinicToPrint = allClinics.Where(x => x.Name == tokens[1]).FirstOrDefault();
                        foreach (var pet in clinicToPrint.Rooms)
                        {
                            if (pet.Pet == null)
                            {
                                Console.WriteLine("Room empty");
                            }
                            else
                            {
                                Console.WriteLine(pet.Pet);
                            }
                        }
                    }
                    else
                    {
                        var clinicToPrint = allClinics.Where(x => x.Name == tokens[1]).FirstOrDefault();
                        var room = clinicToPrint.Rooms[int.Parse(tokens[2])-1];

                        if (room.Pet==null)
                        {
                            Console.WriteLine("Room empty");
                        }
                        else
                        {
                            Console.WriteLine(room.Pet);

                        }

                    }
                    break;
            }

        }
    }
}