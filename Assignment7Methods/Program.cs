using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();

			int val = r.Next(1, 100);
			int guess = 0;
			bool correct = false;

			Console.WriteLine("I'm thinking of a number between 1 and 100.");

			while (!correct)
			{
				Console.Write("Your Guess: ");
				string input = Console.ReadLine();

				if (!int.TryParse(input, out guess))
				{
					Console.WriteLine("That's not a number.");
					continue;
				}

				if (guess < val)
				{
					Console.WriteLine("No, the number I'm thinking of is higher.");
				}
				else if (guess > val)
				{
					Console.WriteLine("No, the number I'm thinking of is lower.");
				}
				else
				{
					correct = true;
					Console.WriteLine("You guessed right!");
					Console.ReadLine();
				}
			}
		}
	}
}