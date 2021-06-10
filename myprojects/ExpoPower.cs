using System;

class Program
{
	static void Main()
	{
		string num = "4 -2";
		string[] numToArray = num.Split(' ');

		int FirstArray = Convert.ToInt32(numToArray[0]);
		int SecondArray = Convert.ToInt32(numToArray[1]);
		if(SecondArray == 0) Console.WriteLine(1);
		else if(SecondArray < 0)
		{
			int b2 = Math.Abs(SecondArray);
			int plus = 1;
			for(int k = 1; k <= b2; k++) plus *= FirstArray;
			Console.WriteLine((double)1 / plus);
		}
		else
		{
			int plus = 1;
			for(int j = 1; j <= SecondArray; j++) plus *= FirstArray;
			Console.WriteLine(plus);
		}
		Console.ReadKey();
	}
}