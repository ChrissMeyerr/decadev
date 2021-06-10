using System;
using System.Text;

class workWithString
{
	static void Main(string[] args)
	{
		//string mystring = String.Format("Currency: {0:C}",123.45);
		//string mystring = String.Format("{0:N}", 123456789);
		//string mystring = String.Format("Percentage: {0:P}",.762);
		//string mystring = string.Format("Phone number: {0: (###) ###-####}",1234567890);

		StringBuilder mystring = new StringBuilder();

		for(var i = 0; i < 100; i++)
		{
			mystring.Append("--");
			mystring.Append(i);
		}

		Console.WriteLine(mystring);
		Console.ReadLine();
	}
}