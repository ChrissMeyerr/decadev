using System;
using System.Linq;


class DigPow
{
	static void Main()
	{
		Console.Write("Enter your p value: ");
		string p = Console.ReadLine();

		Console.Write("Enter your k value: ");
		int k = int.Parse(Console.ReadLine());

		digit(p,k);
	}

	static void digit(string p, int k)
	{
		int sum = 0;
		int numLength = p.Length;

		int[] splitK = Enumerable.Range(k, numLength).ToArray();
		for(int i = 0; i < numLength; i++)
		{
			int collate =(int) Math.Pow(p[i] -'0', splitK[i]);
			sum += collate;
		}
		int pInt = int.Parse(p);
		
		if(sum % pInt == 0) Console.WriteLine(sum/pInt);
		else
		{
			Console.WriteLine(-1);
		}
	}
	
}