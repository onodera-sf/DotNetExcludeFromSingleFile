using System;
using System.Diagnostics;
using System.IO;

namespace ExcludeFromSingleFile
{
	class Program
	{
		static void Main(string[] args)
		{
			using var processModule = Process.GetCurrentProcess().MainModule;
			Console.WriteLine(File.ReadAllText(Path.Combine(Path.GetDirectoryName(processModule.FileName), "TextFile1.txt")));
			Console.ReadKey();
		}
	}
}
