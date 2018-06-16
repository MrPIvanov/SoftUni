namespace _02_CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var collection = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var args = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = args[0];

                switch (command)
                {
                    case "reverse":
                        collection = Reverse(args, collection);
                        break;

                    case "sort":
                        collection = Sort(args, collection);
                        break;

                    case "rollLeft":
                        collection = RollLeft(args, collection);
                        break;

                    case "rollRight":
                        collection =  RollRight(args, collection);
                        break;
                }

            }
            Console.WriteLine($"[{string.Join(", ", collection)}]");

        }

        private static List<string> Sort(List<string> args, List<string> collection)
        {
            var startIndex = long.Parse(args[2]);
            var count = long.Parse(args[4]);

            if (!(startIndex >= 0 && count >= 0 && startIndex <= collection.Count - 1 && startIndex + count - 1 <= collection.Count - 1))
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;

            }

            var tempCollectionToSort = new List<string>();
            var tempCollectionFirstPart = new List<string>();
            var tempCollectionLastPart = new List<string>();
            var finalCollection = new List<string>();


            for (long i = 0; i < startIndex; i++)
            {
                tempCollectionFirstPart.Add(collection[(int)i]);
            }

            for (long i = startIndex; i < startIndex + count; i++)
            {
                tempCollectionToSort.Add(collection[(int)i]);
            }
            for (long i = startIndex + count; i < collection.Count; i++)
            {
                tempCollectionLastPart.Add(collection[(int)i]);
            }

            finalCollection.AddRange(tempCollectionFirstPart);
            tempCollectionToSort= tempCollectionToSort.OrderBy(x=>x).ToList();
            finalCollection.AddRange(tempCollectionToSort);
            finalCollection.AddRange(tempCollectionLastPart);

            collection = finalCollection;
            return collection;

        }

        private static List<string> Reverse(List<string> args, List<string> collection)
        {
            var startIndex = long.Parse(args[2]);
            var count = long.Parse(args[4]);

            if (!(startIndex>=0 && count>=0 && startIndex<= collection.Count - 1 && startIndex + count -1 <= collection.Count - 1))
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;

            }

            var tempCollectionToReverse = new List<string>();
            var tempCollectionFirstPart = new List<string>();
            var tempCollectionLastPart = new List<string>();
            var finalCollection = new List<string>();


            for (long i = 0; i < startIndex; i++)
            {
                tempCollectionFirstPart.Add(collection[(int)i]);
            }

            for (long i = startIndex; i < startIndex+count; i++)
            {
                tempCollectionToReverse.Add(collection[(int)i]);
            }
            for (long i = startIndex+count; i < collection.Count; i++)
            {
                tempCollectionLastPart.Add(collection[(int)i]);
            }

            finalCollection.AddRange(tempCollectionFirstPart);
            tempCollectionToReverse.Reverse();
            finalCollection.AddRange(tempCollectionToReverse);
            finalCollection.AddRange(tempCollectionLastPart);

            collection = finalCollection;
            return collection;

        }

        private static List<string> RollLeft(List<string> args, List<string> collection)
        {
            var rollCount = long.Parse(args[1]) % collection.Count;
            if (rollCount<0)
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;

            }


            var tempCollection = new List<string>();
            for (long i = 0; i < collection.Count; i++)
            {
                tempCollection.Add("0");
            }


            for (long i = 0; i < collection.Count; i++)
            {
                tempCollection[(int)(i - rollCount + collection.Count)%collection.Count] = collection[(int)i];
            }

            collection = tempCollection;

            return collection;
        }

        private static List<string> RollRight(List<string> args, List<string> collection)
        {
            var rollCount = long.Parse(args[1]) % collection.Count;
            if (rollCount < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;

            }


            var tempCollection = new List<string>();
            for (long i = 0; i < collection.Count; i++)
            {
                tempCollection.Add("0");
            }

            for (long i = 0; i < collection.Count; i++)
            {
                tempCollection[(int)(i + rollCount) % collection.Count] = collection[(int)i];
            }

            collection = tempCollection;

            return collection;


        }

        
    }
}