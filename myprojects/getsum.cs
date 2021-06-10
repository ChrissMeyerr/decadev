using System;

class SumOfNumbers
{
	public static void Main()
	{
		Console.Write("Input the value of a: ");
		int intA =Int32.Parse(Console.ReadLine());

		Console.Write("Input the value of b: ");
		int intB = Int32.Parse(Console.ReadLine());

		int theSum = getSum(intA, intB);
		Console.WriteLine(theSum);
	}
	static int getSum(int a, int b)
	{
		if(a == b) return a;

		int GetSum = 0;
		if(a < b)
		{
			for(int i = a; i <= b; i++)
			{
				GetSum += i;
			}
			return GetSum;
		}
		else
			for(int i = b; i <= a; i++)
			{
				GetSum += i;
			}
			return GetSum;
	}
}