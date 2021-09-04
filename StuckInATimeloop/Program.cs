using System;

namespace StuckInATimeloop
{
	class Program
	{
		static void Main(string[] args)
		{
				int x = int.Parse(Console.ReadLine());

				for (int y = 1; y <= x; y++)
				{
					Console.WriteLine(y + " Abracadabra ");
				}
			
		}
	}
}
