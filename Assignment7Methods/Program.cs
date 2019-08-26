using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Methods
{
	class Program
	{
		static void Main()
		{
			Random r = new Random();
			int val = r.Next(1, 100);
			int guess = 0;
			string yesNo;

			do
			{
				Console.WriteLine("Hey, You! Guess a number between 1 and 100!");

				while (guess != val)
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
						Console.WriteLine("My number is higher than " + input);
					}
					else if (guess > val)
					{
						Console.WriteLine("My number is lower than " + input);
					}
					else
					{
						Console.WriteLine("You are correct! (:");
					}
				}
				Console.WriteLine("Press 'e' to exit or 'y' to play again");

				yesNo = Console.ReadLine().ToLower();

				while (!yesNo.Equals("y") && !yesNo.Equals("e"))
				{

					Console.WriteLine("Invalid!");

					Console.WriteLine("Press 'e' to exit or 'y' to play again");

					yesNo = Console.ReadLine().ToLower();

				}

			}
			while (yesNo.Equals("e"));
			{
				Main();

			}
			while (yesNo.Equals("y"));

			System.Environment.Exit(0);
			}

		}
	}
