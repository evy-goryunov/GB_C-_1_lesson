using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Горюнов Евгений
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
// б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

namespace hometasks_5
{
	class Program
	{
		static void Main(string[] args)
		{

			double distance (double x1, double x2, double y1, double y2)
			{
				double r = Math.Sqrt(Math.Pow(x2, x1) + Math.Pow(y2, y1));
				return r;
			}

			Console.WriteLine("{0:F2}", distance(4, 9, 7, 3));
			Console.ReadKey();
		}
	}
}
