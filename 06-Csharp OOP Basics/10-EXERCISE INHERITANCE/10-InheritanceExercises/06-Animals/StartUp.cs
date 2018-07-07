using System;

public class StartUp
{
    static void Main()
    {
        string input;
        while ((input = Console.ReadLine()) != "Beast!")
        {
            var info = Console.ReadLine().Split();
            var name = info[0];
            var age = int.Parse(info[1]);
            var gender = info[2];

            Animal current = null;

            try
            {
                switch (input)
                {
                    case "Dog":
                        current = new Dog(name, age, gender);
                        Console.WriteLine(current);
                        break;

                    case "Cat":
                        current = new Cat(name, age, gender);
                        Console.WriteLine(current);
                        break;

                    case "Frog":
                        current = new Frog(name, age, gender);
                        Console.WriteLine(current);
                        break;

                    case "Kitten":
                        current = new Kitten(name, age, gender);
                        Console.WriteLine(current);
                        break;

                    case "Tomcat":
                        current = new Tomcat(name, age, gender);
                        Console.WriteLine(current);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}