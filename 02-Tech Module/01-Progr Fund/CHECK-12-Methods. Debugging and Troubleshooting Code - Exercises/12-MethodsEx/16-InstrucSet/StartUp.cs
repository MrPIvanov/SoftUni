namespace _16_InstrucSet
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string startingString = "";

            while (startingString != "END")
            {
                startingString = Console.ReadLine().ToUpper();

                if (startingString=="END")
                {
                    break;
                }

                string[] partsOfTheString = startingString.Split(' ');

                long result = 0;

                switch (partsOfTheString[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(partsOfTheString[1]);
                            result = operandOne+1;
                            Console.WriteLine(result);

                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(partsOfTheString[1]);
                            result = operandOne-1;
                            Console.WriteLine(result);

                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(partsOfTheString[1]);
                            long operandTwo = long.Parse(partsOfTheString[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);

                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(partsOfTheString[1]);
                            long operandTwo = long.Parse(partsOfTheString[2]);
                            result = operandOne * operandTwo;
                            Console.WriteLine(result);

                            break;

                        }


                }

            }
        }
    }
}
