using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometasks_1
{
	class Program
	{
		static void Main(string[] args)
		{
			String name;
			String sureName;
			int age;
			int height;
			int weight;

			Console.WriteLine("Назовите ваше имя");
			name = Console.ReadLine();

			Console.WriteLine("Назовите вашу фамилию");
			sureName = Console.ReadLine();

			Console.WriteLine("Назовите свой возраст");
			age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Назовите свой рост");
			height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Назовите свой вес");
			weight = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Имя: " + name + ", Фамилия: " + sureName + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);

			PauseClass.Pause();

			Console.WriteLine($"Имя: {name}, Фамилия: {sureName}, Возраст: {age}, Рост: {height}, Вес: {weight}");

			PauseClass.Pause();



		}
	}
}
