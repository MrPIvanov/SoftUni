using FestivalManager.Core.IO.Contracts;
using System;

namespace FestivalManager.Core.IO
{
    class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
