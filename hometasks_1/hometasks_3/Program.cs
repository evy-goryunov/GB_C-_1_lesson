using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Горюнов Евгений
// Написать программу обмена значениями двух переменных.
// а) с использованием третьей переменной;
// б) * без использования третьей переменной.

namespace hometasks_3
{
	class Program
	{
		static void Main(string[] args)
		{



			int a = 123;
			int b = 456;
			int temp;

			Console.WriteLine("Введите число 0 если хотите обменять переменные с использованием третьей " +
				"или 1 если хотите обменять переменные без использования третьей переменной");

			int counut = Convert.ToInt32(Console.ReadLine());

			if (counut == 1)
			{
				// обмен переменных
				a = a + b;
				b = b - a;
				b = -b;
				a = a - b;
				Console.WriteLine("A равно: " + a);
				Console.WriteLine("B равно: " + b);
			}
			else if (counut == 0)
			{
				temp = a;
				a = b;
				b = temp;
				Console.WriteLine("A равно: " + a);
				Console.WriteLine("B равно: " + b);
			}
			

			Console.ReadKey();

		}
	}
}
