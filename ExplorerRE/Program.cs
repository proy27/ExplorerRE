using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerRE
{
	class Program
	{
		private const string path = @"C:\Windows\explorer.exe";
		static void Main(string[] args)
		{
			var a = Path.GetFileNameWithoutExtension(path);
			//var asd = Process.GetProcessesByName(a);
			var bb = Process.GetProcessesByName(a).Any(p => p.MainModule.FileName.ToUpper() == path.ToUpper());
			if (bb == false)
			{
				Process.Start(path);
			}
			else
			{
				var b2 = Process.GetProcessesByName(a).First(p => p.MainModule.FileName.ToUpper() == path.ToUpper());
				b2.Kill();
				Process.Start(path);
			}

		}
	}
}
