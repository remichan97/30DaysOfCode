using System;
using System.Collections.Generic;
using System.IO;
class SolutionDay6 {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int a = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 1; i <= a; i ++) {
            string odd = " ";
            string even = "";
            string input = Console.ReadLine().Trim();
            for (int b = 0; b < input.Length; b++) {
                if (b % 2 == 0)
                {
                    even += input[b];
                }
                else
                {
                    odd += input[b];
                }
            }
            Console.WriteLine(even + odd);
        }
    }
}
