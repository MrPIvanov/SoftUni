namespace _05_HandOfCard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new Dictionary<string, string>();

            var input = Console.ReadLine()
                .Split(':')
                .ToArray();
            string cards = "";

            while (input[0] != "JOKER")
            {
                cards = input[1];

                if (!result.ContainsKey(input[0]))
                {
                    result.Add(input[0], cards);
                }
                else
                {
                    result[input[0]]+=cards;
                }

                input = Console.ReadLine()
                .Split(':')
                .ToArray();
            }
            var sendCards = new List<string>();

            foreach (var item in result)
            {
                sendCards = item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                int curentEndValue = GetTheCurrentCards(sendCards);

                Console.WriteLine($"{item.Key}: {curentEndValue}");
            }
         

        }

        static int GetTheCurrentCards(List<string> cardsString)
        {
            int currentResult = 0;

            for (int i = 0; i < cardsString.Count; i++)
            {
                int multiplayer = 1;
                int cardValue = 0;

                if (cardsString[i].EndsWith("S"))
                {
                    multiplayer = 4;
                }
                else if (cardsString[i].EndsWith("H"))
                {
                    multiplayer = 3;
                }
                else if (cardsString[i].EndsWith("D"))
                {
                    multiplayer = 2;
                }

                string cardWithRemovedMulti = cardsString[i].Remove(cardsString[i].Length-1,1);

                try
                {
                    cardValue += int.Parse(cardWithRemovedMulti);
                }
                catch (Exception)
                {
                    if (cardWithRemovedMulti == "J")
                    {
                        cardValue += 11;
                    }
                    else if (cardWithRemovedMulti == "Q")
                    {
                        cardValue += 12;
                    }
                    else if (cardWithRemovedMulti == "K")
                    {
                        cardValue += 13;
                    }
                    else
                    {
                        cardValue += 14;
                    }
                }

                currentResult += (cardValue*multiplayer);
            }

            return currentResult;
        }
    }
}