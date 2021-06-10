using System;
/*using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;*/

/*public class Test
{
	public static void Main()
	{		

		Console.WriteLine("Samuel Big Giveaway");
		Console.Write("Choose a number 1,2 or 3: ");
		string userValue = Console.ReadLine();

		string message = "";

		if (userValue == "1") message = "You Won";

		else if(userValue == "2") message = "You won a bike";
		 
		else if(userValue == "3") message = "You won a fighter jet";
		
		else message = "To indicate you arent a robot, a vallid input is required";
		

		Console.WriteLine("You entered {0}, therefore you {1}", userValue, message);
		Console.ReadLine();
	}
}*/

namespace index
{
	class array
	{
		static void Main()
		{
			Console.WriteLine("The Name Game");

			Console.Write("What's your first name? ");
			string FirstName = Console.ReadLine();

			Console.Write("What's is your last name? ");
			string LastName = Console.ReadLine();

			Console.Write("In what city were you born? ");
			string MyCity = Console.ReadLine();
		
			DisplayResult(ReverseString(FirstName),
				ReverseString(LastName),
				ReverseString(MyCity));

			Console.ReadLine();

		}

		private static string ReverseString(string name)
		{
			char[] myReverse = name.ToCharArray();
			Array.Reverse(myReverse);
			return String.Concat(myReverse);
			
		}

		private static void DisplayResult(
			string reverseFirstName,
		 	string reverseLastName,
		 	string reverseMyCity)
		{
			Console.Write("Result: ");
			Console.Write("{0} {1} {2}", 
				reverseFirstName,
				reverseLastName,
				reverseMyCity);
		}
	}
}