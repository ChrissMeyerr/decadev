using System;
using System.Text.RegularExpressions;


class consecString
{
	static void Main()
	{
		string pinCode = "0232110";
		if(pinNum(pinCode))
			Console.WriteLine("True");
		else
			Console.WriteLine("false");

		Console.ReadLine();
	}

	static bool pinNum(string Code)
	{
		if((Code.Length == 4 || Code.Length == 6)
		 && Regex.IsMatch(Code, "[a-zA-Z]") == false)
		  return true;
		else
			return false;

	}
}