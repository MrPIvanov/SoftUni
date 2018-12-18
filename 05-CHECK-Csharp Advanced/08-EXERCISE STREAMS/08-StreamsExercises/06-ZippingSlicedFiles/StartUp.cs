namespace _06_ZippingSlicedFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;

    class StartUp
    {
        static void Main()
        {
            var sourceFile = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\sliceMe.mp4";
            var destinationDirectory = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\";
            int parts = 5;

            SliceAndZip(sourceFile, destinationDirectory, parts);

            var files = new List<string>
            {
                "06-ZippingSlicedFiles-Part-01.mp4.gz",
                "06-ZippingSlicedFiles-Part-02.mp4.gz",
                "06-ZippingSlicedFiles-Part-03.mp4.gz",
                "06-ZippingSlicedFiles-Part-04.mp4.gz",
                "06-ZippingSlicedFiles-Part-05.mp4.gz",
            };

            AssembleFromZipParts(files, destinationDirectory);


        }

        static void SliceAndZip(string sourceFile, string destinationDirectory, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                long partSize = (long)Math.Ceiling((double)reader.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    long currentPartSize = 0;
                    var fileName = $"{destinationDirectory}06-ZippingSlicedFiles-Part-0{i}.mp4.gz";

                    using (GZipStream writer = new GZipStream(new FileStream(fileName, FileMode.Create), CompressionLevel.Optimal))
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

        static void AssembleFromZipParts(List<string> files, string destinationDirectory)
        {
            var assembledFilePath = $"{destinationDirectory}06-ZippingSlicedFiles-Assembled.mp4";

            using (var writer = new FileStream(assembledFilePath, FileMode.Create))
            {
                var buffer = new byte[4096];

                for (int i = 0; i < files.Count; i++)
                {
                    var filePath = $"{destinationDirectory}{files[i]}";

                    using (var decompressionStram = new GZipStream(new FileStream(filePath, FileMode.Open), CompressionMode.Decompress))
                    {
                        var readBytesCount = decompressionStram.Read(buffer, 0, buffer.Length);

                        while (readBytesCount != 0)
                        {
                            writer.Write(buffer, 0, readBytesCount);
                            readBytesCount = decompressionStram.Read(buffer, 0, buffer.Length);
                        }
                    }

                }

            }

        }
    }
}