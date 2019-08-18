using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountchecker
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("What would you like to do");
			var input = Console.ReadLine();


			userInterface face = new userInterface(input);
		}
	}
}
