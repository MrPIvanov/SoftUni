namespace _01_OddLines
{
    using System;
    using System.IO;

    class StartUp
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\text.txt");
            var line = -1;

            using (reader)
            {
                var lineText = reader.ReadLine();
                while (lineText != null)
                {
                    line++;
                    if (line%2==1)
                    {
                        Console.WriteLine(lineText);
                    }
                    lineText = reader.ReadLine();

                }
              
            }


        }
    }
}