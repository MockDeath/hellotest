using System;

namespace hellotest
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int number = rnd.Next(1, 1000);
			Console.WriteLine("Guess a number between 1 and 1000!");
			bool playing = true;
			int counter = 0;
			while (playing)
			{
				string numberPick = Console.ReadLine();
				int.TryParse(numberPick, out int i);
				counter ++;
				if (i == 0)
				{
					Console.WriteLine("I said pick a number between 1 and 1000! They are the keys above QWERTYUIOP and no, not 0");
				}
				if (i == number)
				{
					Console.WriteLine("Perfect!");
					playing = false;
					continue;
				}
				if (i > number)
				{
					Console.WriteLine("Lower!");
				}
				if (i < number)
				{
					Console.WriteLine("Higher!");
				}
			}
			Console.WriteLine("You got it in "+counter+" guesses! Well done now GTFO");
			Console.ReadLine();
		}
	}
}
