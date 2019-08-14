namespace _02_LineNumbers
{
    using System;
    using System.IO;

    class StartUp
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\text.txt");
            StreamWriter writer = new StreamWriter(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\02-LineNumbers.txt");

            using (reader)
            {
                using (writer)
                {
                    var line = reader.ReadLine();
                    var lineCounter = 0;

                    while (line != null)
                    {
                        lineCounter++;
                        writer.WriteLine($"Line {lineCounter}:{line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}