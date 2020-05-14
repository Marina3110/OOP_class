using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Animal
	{
		private int _age;
		internal string Name { get; set; }
		internal int Age
		{
			get => _age;
			set
			{
				if(value < 0) _age = 1;
				else _age = value;
			}
		}
		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
		}
		public virtual void Speak()
		{
			Console.WriteLine("Nothing");
		}
	}
}
