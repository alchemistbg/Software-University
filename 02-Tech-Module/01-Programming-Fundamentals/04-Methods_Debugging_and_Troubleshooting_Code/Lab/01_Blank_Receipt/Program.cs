using System;

namespace _01_Blank_Receipt
{
	class Program
	{
		//Some bug in judje - doesn't accept this solution
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			printReceipt();
		}

		static void printReceipt()
		{
			PrintReceiptHeader();
			PrintReceiptBody();
			PrintReceiptFooter();
		}

		static void PrintReceiptHeader()
		{
			Console.WriteLine("CASH RECEIPT");
			Console.WriteLine("------------------------------");
		}

		static void PrintReceiptBody()
		{
			Console.WriteLine("Charged to____________________");
			Console.WriteLine("Received by___________________");
		}

		static void PrintReceiptFooter()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine(@"© SoftUni");
		}
	}
}
