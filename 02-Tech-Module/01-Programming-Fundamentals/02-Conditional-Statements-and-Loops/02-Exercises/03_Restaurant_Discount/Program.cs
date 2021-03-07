using System;

namespace _03_Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			int personNumber = int.Parse(Console.ReadLine());
			string service = Console.ReadLine();

			string hall = "";

			double price = 0.0;
			double discount = 0.0;

			double totalPrice = 0.0;
			double pricePerPerson = 0.0;

			if (personNumber > 120)
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}
			else
			{
				if (personNumber <= 50)
				{
					hall = "Small Hall";
					price = 2500;
				}
				else if (personNumber > 50 && personNumber <= 100)
				{
					hall = "Terrace";
					price = 5000;
				}
				else if (personNumber > 100 && personNumber <= 120)
				{
					hall = "Great Hall";
					price = 7500;
				}

				if (service.Equals("Normal"))
				{
					discount = 0.05;
					price = price + 500;
				}
				else if (service.Equals("Gold"))
				{
					discount = 0.1;
					price = price + 750;
				}
				else if (service.Equals("Platinum"))
				{
					discount = 0.15;
					price = price + 1000;
				}

				totalPrice = price - (price * discount);
				pricePerPerson = totalPrice / personNumber;

				Console.WriteLine($"We can offer you the {hall}");
				Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
			}
		}
	}
}
