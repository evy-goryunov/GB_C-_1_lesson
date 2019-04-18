using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometasks_3
{
	class Program
	{
		static void Main(string[] args)
		{

			int a = 123;
			int b = 456;

			a = a + b;
			b = b - a;
			b = -b;
			a = a - b;

			Console.WriteLine("A равно: " + a);
			Console.WriteLine("B равно: " + b);

			Console.ReadKey();

		}
	}
}
