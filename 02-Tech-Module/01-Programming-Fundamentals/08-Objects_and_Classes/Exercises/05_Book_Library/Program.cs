using System;

namespace _05_Book_Library
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			List<Book> books = new List<Book>();
			for (int i = 0; i < num; i++)
			{
				string[] bookData = Console.ReadLine().Split(' ');
				Book book = new Book();
				book.Title = bookData[0];
				book.Author = bookData[1];
				book.Publisher = bookData[2];
				book.ReleaseDate = DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
				book.ISBN = bookData[4];
				book.Price = double.Parse(bookData[5]);

				books.Add(book);
			}

			Library library = new Library();
			library.Name = "Super Cool Library";
			library.Books = books;

			foreach (var book in library.Books.GroupBy(x => x.Author).
									OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):f2}");
			}
			//Console.WriteLine(library.Books);
		}
	}

	class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Publisher { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string ISBN { get; set; }
		public double Price { get; set; }

		public Book()
		{

		}
	}

	class Library
	{
		public string Name { get; set; }
		public List<Book> Books { get; set; }

		public Library()
		{

		}
	}
}
