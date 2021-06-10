using System;

class Program
{
	static void Main()
	{
		int[,] newArray = new int[,] {{1,2,3},{4,5,6}};

		int p = 1;
		for(int i = 0; i < newArray.GetLength(0); i++)
		{
			int sum = 0;

			for(int j = 0; j < newArray.GetLength(1); j++)
			{	
				sum += newArray[i, j];
			}
			p *= sum;
		Console.Write("{0} ",sum);
		} 
	}
}