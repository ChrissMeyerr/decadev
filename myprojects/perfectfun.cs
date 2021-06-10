using System;

class perfectFun
{
	static void  Main()
	{
		int[] array = new int[] {21,4,3,54,2,1};
		/*int len = 1234;

		string lengs = len.ToString();
		char[] lenarray = lengs.ToCharArray();
		int lengthLen = lengs.Length;
		int perfect =(int) Math.Floor((double)Math.Sqrt(lengthLen));

		if(Math.Pow(perfect, 2) == lengthLen)
			for(int i = 0; i < lengthLen-perfect; i++)
			{
				//string a = lengs.Substring(i,perfect);
				string a = lengs.Remove(i,perfect);
				Console.WriteLine(a);
			}
		else
			Console.WriteLine("not a squreroot");*/
			//char[] array = words.ToCharArray();
			Array.Sort(array);
			foreach(var arr in array)
			{
				Console.Write(arr);
				Console.Write(" ");
			}
			Console.ReadLine();
	}
}