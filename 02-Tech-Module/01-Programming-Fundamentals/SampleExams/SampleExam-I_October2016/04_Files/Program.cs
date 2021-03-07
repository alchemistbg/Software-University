using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Files
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, long> files = new Dictionary<string, long>();
			int folderCount = int.Parse(Console.ReadLine());
			for (int i = 0; i < folderCount; i++)
			{
				string path = Console.ReadLine();
				string root = path.Substring(0, path.IndexOf("\\"));
				string fileInfo = path.Substring(path.LastIndexOf("\\") + 1);
				string[] fileInfoArr = fileInfo.Split(';');
				string fileName = fileInfoArr[0];
				long fileSize = long.Parse(fileInfoArr[1]);

				string fileKey = root + ";" + fileName;
				files[fileKey] = fileSize;
			}
			string[] filterArr = Console.ReadLine().Split(new char[] { ' ', 'i', 'n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var filtered = files.Where(x => x.Key.StartsWith(filterArr[1])).Where(x => x.Key.EndsWith(filterArr[0]));
			if (filtered.Count() < 1)
			{
				Console.WriteLine("No");
			}
			else
			{
				foreach (var file in filtered.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"{file.Key.Substring(file.Key.IndexOf(';') + 1)} - {file.Value} KB");
				}
			}

		}
	}
}
