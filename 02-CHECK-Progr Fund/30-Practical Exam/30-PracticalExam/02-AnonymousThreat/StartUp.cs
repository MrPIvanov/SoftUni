namespace _02_AnonymousThreat
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var collections = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
               var inputArgs = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputArgs[0];

                switch (command)
                {
                    case "merge":
                        var startIndex = Math.Max(int.Parse(inputArgs[1]),0);
                        if (startIndex>collections.Count-1)
                        {
                            break;
                        }

                        var endIndex = Math.Min(int.Parse(inputArgs[2]), collections.Count-1);
                        var resultToAdd = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            resultToAdd += collections[i];
                        }

                        collections.RemoveRange(startIndex,endIndex-startIndex);
                        collections[startIndex] = resultToAdd;



                        break;

                    case "divide":
                        var index = int.Parse(inputArgs[1]);
                        var partitions = int.Parse(inputArgs[2]);

                        var textToDivide = collections[index];
                        collections.RemoveAt(index);
                        var indexCounter = index;
                        var onePartLenght = textToDivide.Length / partitions;


                        for (int i = 0; i < partitions; i++)
                        {
                            if (i!=partitions-1)
                            {
                                var partToAdd = textToDivide.Take(onePartLenght);
                                var realPartToAdd = "";

                                foreach (var item in partToAdd)
                                {
                                    realPartToAdd += item;
                                }

                                textToDivide =  textToDivide.Substring(onePartLenght);
                                collections.Insert(indexCounter, realPartToAdd);
                                indexCounter++;

                            }
                            else
                            {
                                var partToAdd = textToDivide;
                                collections.Insert(indexCounter, partToAdd);

                            }

                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", collections));


        }
    }
}