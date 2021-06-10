using System;

class learnClass
{
	static void Main()
	{
		Car carmake = new Car();

		/*carmake.Make = "Nissan";
		carmake.Model = "Newraw";
		carmake.Year = 1993;
		carmake.Color = "Blue";*/

		Console.WriteLine("{0} {1} {2} {3}",
			carmake.Make, carmake.Model,
			carmake.Year, carmake.Color);

		DateTime datenow = DateTime.Now;
		DateTime date = new DateTime(1993,12,1);
		TimeSpan mydays = datenow.Subtract(date);
		Console.WriteLine(Math.Floor(mydays.TotalDays));
		Console.ReadLine();
	}
}

class Car
{
	public string Make { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
	public string Color { get; set; }

	public Car()
	{
		Make = "Toyota";
	}
}