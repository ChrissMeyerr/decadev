using System;

class DescendingClass
{
	public static void Main()
	{
		Console.Write("input integer n: ");
		int n = Int32.Parse(Console.ReadLine());

		string num = n.ToString();
		char[] array = num.ToCharArray();
		Array.Sort(array, 0, array.Length);
		foreach(char arr in array)
		{
			Console.Write(arr);
		}
		Console.ReadLine();
	}
}