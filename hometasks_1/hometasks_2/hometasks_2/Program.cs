using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometasks_2
{
	class Program
	{
		static void Main(string[] args)
		{
			double weight;
			double height;
			double bodyMassIndex;

			weight = Convert.ToDouble(Console.ReadLine());
			height = Convert.ToDouble(Console.ReadLine());

			bodyMassIndex = weight / (height * height);

			Console.WriteLine(bodyMassIndex);
			Console.ReadKey();
		}
	}
}
