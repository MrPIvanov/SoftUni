namespace _05_SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class StartUp
    {
        static void Main()
        {
            var sourceFile = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\sliceMe.mp4";
            var destinationDirectory = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\";
            int parts = 5;

            Slice(sourceFile, destinationDirectory, parts);

            var files = new List<string>
            {
                "05-SlicingFile-Part-01.mp4",
                "05-SlicingFile-Part-02.mp4",
                "05-SlicingFile-Part-03.mp4",
                "05-SlicingFile-Part-04.mp4",
                "05-SlicingFile-Part-05.mp4",
            };

            Assemble(files, destinationDirectory);


        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                long partSize = (long)Math.Ceiling((double)reader.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    long currentPartSize = 0;
                    var fileName = $"{destinationDirectory}05-SlicingFile-Part-0{i}.mp4";
                    using (var writer = new FileStream(fileName, FileMode.Create))
                    {
                        var buffer = new byte[4096];

                        while (reader.Read(buffer, 0, buffer.Length) == 4096)
                        {
                            writer.Write(buffer, 0, buffer.Length);
                            currentPartSize += 4096;
                            if (currentPartSize >= partSize)
                            {
                                break;
                            }
                        }

                    }
                }


            }

        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            var assembledFilePath = $"{destinationDirectory}05-SlicingFile-Assembled.mp4";

            using (var writer = new FileStream(assembledFilePath, FileMode.Create))
            {
                var buffer = new byte[4096];

                for (int i = 0; i < files.Count; i++)
                {
                    var filePath = $"{destinationDirectory}{files[i]}";

                    using (var reader = new FileStream(filePath, FileMode.Open))
                    {
                        while (reader.Read(buffer,0,buffer.Length) != 0)
                        {
                            writer.Write(buffer, 0, buffer.Length);
                        }

                    }
                }

            }

        }
    }
}