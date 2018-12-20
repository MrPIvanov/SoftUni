using Travel.Core.IO.Contracts;
using System;

namespace Travel.Core.IO
{
	public class ConsoleWriter : IWriter
	{
		public void WriteLine(string contents)
		{
			Console.WriteLine(contents);
		}

		public void Write(string contents)
		{
            Console.Write(contents);
		}
	}
}