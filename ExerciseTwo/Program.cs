using System;

namespace ExerciseTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			int age = 23;
			int height = 70;
			Console.WriteLine("Age = " + age + '\n' + "Height = " + height);
			Console.WriteLine("I am " + age + " years old, my max heart rate is " + (220 - age) + " and I am " + height + " inches tall.");
		}
	}
}
