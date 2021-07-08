using System;
using System.IO;
namespace C_SHARP_PRAC
{
	class Program
	{

		static void Display(int i)
		{
			Console.WriteLine("Param passed : " + i);
		}

		static void printForTen(int j)
		{
			for (int i = 1; i < j + 1; i++)
			{
				Console.WriteLine(i);

			}
		}

		static void displayName(string name, int age)
		{
			Console.WriteLine("Name :" + name + ", Age: " + age);
		}

		static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
		{
			Console.WriteLine("The youngest child is: " + child3);
		}
		static void Main(string[] args)
		{

			//var i = 10;
			newclass nc = new newclass();
			Console.WriteLine(value: nc.color);
		}
	}
}
