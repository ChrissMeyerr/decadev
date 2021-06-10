using System;

namespace whileIteration
{
	class whileLoop
	{
		static void Main(string[] args)
		{
			bool displayMenu = true;
			while(displayMenu == true)
			{
				displayMenu = MainOption();
			}
		}

		private static bool MainOption()
		{
			Console.WriteLine("1) option 1");
			Console.WriteLine("2) option 2");
			Console.WriteLine("3) Exit");
			string option = Console.ReadLine();
			//ifStatement(option);
			if(option == "1")
			{
				optionOne();
				return true;
			}
			else if(option == "2")
			{
				optionOne();
				return true;
			}
			else if(option == "3")
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private static void optionOne()
		{
			Console.WriteLine("Printed Number");
			Console.ReadLine();
		}
	}
}