using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table [0, 0] = "Георги"; table [0, 1] = "Крумов"; table [0, 2] = "71";

			//Въвеждане на втори ред
			table [1, 0] = "Крум"; table [1, 1] = "Георгиев"; table [1, 2] = "39";


			//Печат
			Console.WriteLine ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table [_index, 0]) [0] + ", " + table [_index, 1] + ", " + table [_index, 2] + " г.");
		}
	}
}


























 
