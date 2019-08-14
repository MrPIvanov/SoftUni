namespace _02_HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var broadcastCode = new List<string>();
            var broadcastMessage = new List<string>();
            var messagesCode = new List<string>();
            var messagesMessage = new List<string>();
            var patternMessages = @"^([0-9]+) <-> ([0-9a-zA-Z]+$)";
            var patternBroadcast = @"^([^0-9]+) <-> ([0-9a-zA-Z]+$)";

            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                
                if (Regex.IsMatch(input,patternMessages))
                {
                    var code = Regex.Match(input, patternMessages).Groups[1].Value.ToCharArray().Reverse();
                    var codeReverse = "";
                    foreach (var letter in code)
                    {
                        codeReverse += letter;
                    }

                    var message = Regex.Match(input, patternMessages).Groups[2].Value;

                    messagesCode.Add(codeReverse);
                    messagesMessage.Add(message);

                }
                else if (Regex.IsMatch(input, patternBroadcast))
                {
                    var broadcastCodeToChange = Regex.Match(input, patternBroadcast).Groups[2].Value;
                    var broadcastMessageToAdd = Regex.Match(input, patternBroadcast).Groups[1].Value;
                    var broadcastCodeFinal = "";

                    foreach (var item in broadcastCodeToChange)
                    {
                        if (char.IsUpper(item))
                        {
                            broadcastCodeFinal += item.ToString().ToLower();
                        }
                        else
                        {
                            broadcastCodeFinal += item.ToString().ToUpper();
                        }

                    }

                    broadcastCode.Add(broadcastCodeFinal);
                    broadcastMessage.Add(broadcastMessageToAdd);

                }
            }

            Console.WriteLine($"Broadcasts:");
            if (broadcastCode.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcastCode.Count; i++)
                {
                    Console.WriteLine($"{broadcastCode[i]} -> {broadcastMessage[i]}");
                }
            }

            Console.WriteLine($"Messages:");
            if (messagesCode.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messagesCode.Count; i++)
                {
                    Console.WriteLine($"{messagesCode[i]} -> {messagesMessage[i]}");
                }
            }


        }
    }
}