﻿using System;
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


			Console.WriteLine("Введите ваш вес в килограммах.");
			weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите ваш рост в метрах.");
			height = Convert.ToDouble(Console.ReadLine());

			bodyMassIndex = weight / (height * height);

			Console.WriteLine("Ваш ИМТ: " + bodyMassIndex);

			if (bodyMassIndex <= 18)
			Console.WriteLine("У вас дефицит веса.");
			else if (bodyMassIndex > 18 && bodyMassIndex <= 28) Console.WriteLine("Ваш вес в норме.");
			else if (bodyMassIndex > 28) Console.WriteLine("У вас лишний вес.");
			Console.ReadKey();
		}
	}
}
