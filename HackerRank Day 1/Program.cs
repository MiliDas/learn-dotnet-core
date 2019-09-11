using System;

namespace HackerRank_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

        
            // Declare second integer, double, and String variables.
            int j;

            double e;

            string t;
        
            // Read and save an integer, double, and String to your variables.
            j = int.Parse(Console.ReadLine());

            e = Double.Parse(Console.ReadLine());

            t = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i+j);
        
            // Print the sum of the double variables on a new line.
            var u = string.Format("{0:0.0}", d+e);
            Console.WriteLine(u);
            
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s+t);
        }
    }
}
