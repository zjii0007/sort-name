using System;
using System.Linq;

namespace sort_name
{
	public class sortName
	{
		/// Entry point
		public static void Main()
		{
			Console.Write("Enter Integer: ");
			string args = Console.ReadLine();
			while (!args.Equals("name-sorter ./unsorted-names-list.txt"))
			{
				Console.WriteLine("Invalid command! Useage: name-sorter ./unsorted-names-list.txt");
				Console.Write("Enter Integer: ");
				args = Console.ReadLine();
			}

			// Take each argument as a filename:
			// read the file
			var readFile = System.IO.File.ReadAllLines(args);
			var names = sortedNames(readFile);
			foreach (string name in names)
			{
				System.Console.WriteLine(name);
			}
			System.IO.File.WriteAllLines(@"sorted-names-list.txt", names);

		}

		public static string[] sortedNames(string[] names)
		{
			
			// get a parallel array for sorting
			var sortKey = names.Select(theLastToFirst).ToArray();
			System.Array.Sort(sortKey, names);
			return names;
		}

		

		// param: the name inside .txt 
		// return the name with the surname placed at the front
		public static string theLastToFirst(string name)
		{
			// split name to single word
			var names = name.Split(' ', System.StringSplitOptions.None);
			var length = names.Length;
			// put the surname at the front
			return names[length - 1] + ' ' + string.Join(' ', names, 0, length - 1);
		}
	}
}
