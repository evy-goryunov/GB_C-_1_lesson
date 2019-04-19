using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Горюнов Евгений
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) Сделать задание, только вывод организуйте в центре экрана
// в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

namespace hometasks_4
{
	class Program
	{
		static void Main(string[] args)
		{


			//String tx = "Евгений Горюнов, г. Пенза";
			//Print.Centered(tx);

			String name = "Евгений";
			String sureName = "Горюнов";
			String homeTown = "Пенза";

			Print.Centered();
			Console.WriteLine($"Имя: {name}, Фамилия: {sureName}, Город: {homeTown}");
			Console.ReadKey();
		}
	}
}
