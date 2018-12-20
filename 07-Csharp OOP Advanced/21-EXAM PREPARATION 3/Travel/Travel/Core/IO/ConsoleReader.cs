using System;
using Travel.Core.IO.Contracts;

namespace Travel.Core.IO
{
	public class ConsoleReader : IReader
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}