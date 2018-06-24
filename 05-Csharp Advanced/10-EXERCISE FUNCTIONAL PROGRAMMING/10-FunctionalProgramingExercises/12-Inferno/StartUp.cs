namespace _12_Inferno
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var allGems = Console.ReadLine().Split().Select(int.Parse).ToList();
            var tempGems = new List<int>();
            foreach (var gem in allGems)
            {
                tempGems.Add(gem);
            }

            var allFilters = new List<string>();

            string input;
            while ((input=Console.ReadLine()) != "Forge")
            {
                var command = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Exclude":
                        allFilters.Add($"{command[1]} {command[2]}");
                        break;

                    case "Reverse":
                        allFilters.Remove($"{command[1]} {command[2]}");
                        break;
                }
            }

            var removedGemsCounter = 0;
            foreach (var filter in allFilters)
            {
                var taskArgs = filter.Split();
                var task = "";
                var sum = 0;
                if (taskArgs.Count()>3)
                {
                    task = $"{taskArgs[0]} {taskArgs[1]} {taskArgs[2]}";
                    sum = int.Parse(taskArgs[3]);
                }
                else
                {
                    task = $"{taskArgs[0]} {taskArgs[1]}";
                    sum = int.Parse(taskArgs[2]);
                }

                

                switch (task)
                {
                    case "Sum Left":

                        for (int i = 0; i < allGems.Count(); i++)
                        {
                            var currentNumber = allGems[i];
                            var leftNumber = 0;
                            try
                            {
                                leftNumber = allGems[i - 1];
                            }
                            catch (Exception)
                            {
                                
                            }

                            if (currentNumber + leftNumber == sum)
                            {
                                tempGems.RemoveAt(i - removedGemsCounter);
                                removedGemsCounter++;
                            }
                            
                        }

                        break;

                    case "Sum Right":

                        for (int i = 0; i < allGems.Count(); i++)
                        {
                            var currentNumber = allGems[i];
                            var rightNumber = 0;
                            try
                            {
                                rightNumber = allGems[i + 1];
                            }
                            catch (Exception) { }

                            if (currentNumber + rightNumber == sum)
                            {
                                tempGems.RemoveAt(i - removedGemsCounter);
                                removedGemsCounter++;
                            }

                        }

                        break;

                    case "Sum Left Right":

                        for (int i = 0; i < allGems.Count(); i++)
                        {
                            var currentNumber = allGems[i];
                            var leftNumber = 0;
                            var rightNumber = 0;
                            try
                            {
                                rightNumber = allGems[i + 1];
                            }
                            catch (Exception){}

                            try
                            {
                                leftNumber = allGems[i - 1];
                            }
                            catch (Exception) { }

                            if (currentNumber + rightNumber + leftNumber == sum)
                            {
                                tempGems.RemoveAt(i - removedGemsCounter);
                                removedGemsCounter++;
                            }

                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(" ",tempGems));


        }
    }
}