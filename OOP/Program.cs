using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			var dog1 = new Dog("Петя", 8, "Овчарка");
			dog1.Speak();
			Console.ReadKey();

		}
	}
}

