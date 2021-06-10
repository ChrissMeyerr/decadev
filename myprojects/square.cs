using System;

class perfectSquare
{
	static void  Main()
	{
		int number = 144;
		double aba = perfect(number);

		Console.WriteLine(aba);
	}

	static double perfect(int num)
	{
		int a = (int) Math.Floor((double)Math.Sqrt(num));

		if(Math.Pow(a, 2) == num) return (Math.Pow(a+1, 2));
		else
			return -1;
	}
}