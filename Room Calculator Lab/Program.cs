using System;

namespace Room_Calculator_Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			//input
			Console.WriteLine("Welcome to the Grand Circus Room Detail Generator");
			Console.WriteLine(" ");
			string answer = string.Empty;

			do
			{
				Console.Write("Enter Length of room: ");
				string roomLength = Console.ReadLine();

				Console.Write("Enter Width: ");
				string roomWidth = Console.ReadLine();

				Console.Write("Enter Height: ");
				string roomHeight = Console.ReadLine();

				//process
				double length = double.Parse(roomLength);
				double width = double.Parse(roomWidth);
				double height = double.Parse(roomHeight);

				double area = (length * width);
				double perimeter = (2 * (length + width));
				double volume = ((length * width) + height);
				//output
				Console.WriteLine("Area: " + area);
				Console.WriteLine("Perimeter: " + perimeter);
				Console.WriteLine("Volume: " + volume);

				Console.Write("Continue? (y/n) ");
				answer = Console.ReadLine();
			}
			while (answer == "y");
				
		}
	}
}
