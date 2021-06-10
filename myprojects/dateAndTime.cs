using System;

namespace NewYearCountDoown
{
	class dateandtime
	{
		static void Main()
		{
			DateTime newYear = new DateTime(2022, 1, 1);
			DateTime myValue = DateTime.Now;
			//Console.WriteLine(myValue.ToShortDateString());
			//Console.WriteLine(myValue.ToShortTimeString());
			TimeSpan daysRemain = newYear.Subtract(myValue);

			double daysleft = Math.Floor(daysRemain.TotalDays);
			double hoursleft = Math.Floor(daysRemain.TotalHours % 24);
			double minutesleft = Math.Floor(daysRemain.TotalMinutes % 60);
			double secondsleft = Math.Floor(daysRemain.TotalSeconds % 60);


			Console.WriteLine("{0} {1} {2} {3}",
				daysleft,hoursleft,
				minutesleft, secondsleft);
			Console.ReadLine();
		}
	}
}