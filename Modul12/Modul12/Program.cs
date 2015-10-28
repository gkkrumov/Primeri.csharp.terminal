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
			a = 25; b = 15;
			sum = a + b;

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни опператори
			Console.WriteLine ("\nИзползване на += ");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine  ( a );

			Console.WriteLine ("\nИзползване на ++");
			a++;
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно делене:" + (187 /14).ToString ());
			Console.WriteLine ("Остатък от делене:" + (187 % 14).ToString ());
		}
	}
}
