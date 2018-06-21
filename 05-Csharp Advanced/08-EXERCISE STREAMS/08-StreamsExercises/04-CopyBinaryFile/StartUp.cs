namespace _04_CopyBinaryFile
{
    using System;
    using System.IO;

    class StartUp
    {
        static void Main()
        {
            FileStream source = new FileStream(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\Resources\copyMe.png",FileMode.Open);
            FileStream  destination = new FileStream(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\04-CopyBinaryFile.png", FileMode.Create);

            using (source)
            {
                using (destination)
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes = source.Read(buffer,0,buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, buffer.Length);
                    }
                }

            }



        }
    }
}