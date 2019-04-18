using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometasks_1
{
	/// <summary>
	/// вспомогательный класс
	/// </summary>
	class PauseClass
	{
		/// <summary>
		/// ожидание нажатия клавиши
		/// </summary>
		public static void Pause()
		{
			Console.ReadKey();
		}
	}
}
