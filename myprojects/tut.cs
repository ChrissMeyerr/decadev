using System;

namespace tut
{
	class array
	{
		static void Main()
		{
			bool playAgain = true;
			while(playAgain)
			{
				playAgain = playGame();
				Console.WriteLine();
			}
		}

		public static bool playGame()
		{
			Console.Clear();
			Console.WriteLine("Lets Play a Game");

			Console.Write("Pick a Number at Random: ");
			string pickNumber = Console.ReadLine();

			ifStatement(pickNumber);

			Console.Write("Do you want to play again [y/n]? ");
			string yesNo = Console.ReadLine();

			if(yesNo == "y" || yesNo == "Y") return true;
			else if(yesNo == "n" || yesNo == "N") return false;

			else
			{
				return true;
			}
		}

		private static void ifStatement(string number)
		{
			Console.Clear();
			string message = "";
			Random random = new Random();
			int randomNum = random.Next(1,10);
			string RandomToString = randomNum.ToString();
			
			if (number == RandomToString)
			{
				message = "You Won, proceed to pick a number for your gift";
				Console.WriteLine(message);

				Console.Write("Pick a letter: ");
				string pickLetter = Console.ReadLine();

				giftBox(pickLetter);

			}else
			{
				message = "Try again next time";
				Console.WriteLine(message);
				Console.ReadLine();
			}
		}

		private static void giftBox(string letter)
		{
			Console.Clear();
			if(letter == "a" || letter == "f" || letter == "y")
			{
				Console.WriteLine("Congratulations You Won yourself a car");
			}
			else
			{	
				Console.WriteLine("You are almost there, better luck next time");
			}
			Console.ReadLine();
		}
	}
}