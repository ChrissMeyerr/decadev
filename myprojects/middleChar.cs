using System;

class MiddleChar
{
	static void Main()
	{
		string sentence = "adeazaesun";

		int charLength = sentence.Length;

		int middle = charLength/2;

		if(charLength % 2 == 1) Console.WriteLine(sentence[middle]);
		else
			Console.WriteLine(String.Concat(sentence[middle - 1], 
				sentence[middle]));
	}
}