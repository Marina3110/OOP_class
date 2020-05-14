using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Dog : Animal
	{
		internal string Breed { get; }

		public Dog(string name, int age, string breed)
			: base(name, age)
		{
			Breed = breed;
		}
		public override void Speak()
		{
			Console.WriteLine("Woof");
		}
	}
}
