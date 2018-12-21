using CosmosX.Core.Contracts;
using CosmosX.IO.Contracts;
using System;

namespace CosmosX.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private ICommandParser commandParser;
        private bool isRunning;

        public Engine(IReader reader, IWriter writer, ICommandParser commandParser)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandParser = commandParser;
            this.isRunning = false;
        }

        public void Run()
        {
            this.isRunning = true;

            while (this.isRunning)
            {
                var input = reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    this.isRunning = false;
                }

                var result = string.Empty;
                try
                {
                    result = this.commandParser.Parse(input);


                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }

                //Console.WriteLine(result);
                writer.WriteLine(result);
            }

            this.writer.Flush();
        }
    }
}