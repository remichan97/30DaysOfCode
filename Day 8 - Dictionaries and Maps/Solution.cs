using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Dictionary<string, int> phoneBook = new Dictionary<string, int>(n);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string name = input[0];
            int number = int.Parse(input[1]);
            phoneBook.Add(name, number);
        }

		string query;
		while ((query = Console.ReadLine()) != null)
		{
			try
			{
				Console.WriteLine($"{query}={phoneBook[query]}");
			}
			catch
			{
				 Console.WriteLine("Not found");
			}
		}
    }
}