using System;

namespace _04_Files
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	namespace Task04
	{
		class Program_v2
		{
			static void Main(string[] args)
			{
				Dictionary<string, File> files = new Dictionary<string, File>();
				int NumberOfFiles = int.Parse(Console.ReadLine());

				for (int i = 0; i < NumberOfFiles; i++)
				{
					string[] FileInput = Console.ReadLine().Split(';');
					string[] FilePath = FileInput[0].Split('\\');

					string fileRoot = FilePath[0];
					string fileName = FilePath[FilePath.Length - 1];
					string key = fileRoot + fileName;
					long fileSize = long.Parse(FileInput[1]);

					File f = new File();
					f.FileRoot = fileRoot;
					f.FileName = fileName;
					f.FileSize = fileSize;

					if (!files.ContainsKey(key))
					{
						files.Add(key, f);
					}
					else
					{
						files[key].FileSize = fileSize;
					}
				}

				string fileFilter = Console.ReadLine();
				string extension = fileFilter.Substring(0, fileFilter.IndexOf(" in "));
				string root = fileFilter.Substring(fileFilter.IndexOf(" in ") + 4);

				var FilteredFiles = files.Where(x => x.Value.FileRoot == root).
											Where(x => x.Value.FileName.EndsWith(extension)).
											OrderByDescending(x => x.Value.FileSize).ThenBy(x => x.Value.FileName);

				if (FilteredFiles.Count() == 0)
				{
					Console.WriteLine("No");
				}
				else
				{
					foreach (var file in FilteredFiles)
					{
						Console.WriteLine($"{file.Value.FileName} - {file.Value.FileSize} KB");
					}
				}

			}
		}

		class File
		{
			public string FileRoot { get; set; }
			public string FileName { get; set; }
			public long FileSize { get; set; }
		}
	}
}
