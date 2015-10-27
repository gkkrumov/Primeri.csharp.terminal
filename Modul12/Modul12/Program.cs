using System;

namespace Modul12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на числа
			a = 11112; b = 128;
			sum = a + b;

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);					

		}
	}
}
