using System;

class WhoLikeIt
{
	static void Main()
	{
		string[] pageUser = new string[] {"allos", "Odun", "ayomide",
		"adewumi", "adeosun", "seun"};
		
		string message = "";

		if(pageUser.Length == 0)
		{
			message = "no one like this";
			Console.WriteLine(message);
		}

		if(pageUser.Length == 1)
		{
			message = String.Format("{0} likes this", pageUser[0]);
			Console.WriteLine(message);
		}

		if(pageUser.Length == 2)
		{
			message = String.Format("{0} and {1} like this",
			 pageUser[0], pageUser[1]);
			Console.WriteLine(message);
		}

		if(pageUser.Length == 3)
		{
			message = String.Format("{0}, {1} and {2} like this",
			 pageUser[0], pageUser[1], pageUser[2]);
			Console.WriteLine(message);
		}

		if(pageUser.Length > 3)
		{
			message = String.Format("{0}, {1} and {2} others like this",
			 pageUser[0], pageUser[1], pageUser.Length-2);
			Console.WriteLine(message);
		}
		Console.ReadLine();
	}
}