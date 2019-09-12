using System;

namespace HackerRank_Day_3
{
    class Program
    {
        static void solve(int N) {
            if(N%2!=0){
                Console.WriteLine("Weird");
            }
            
            if(N%2==0 && N >= 2 && N <= 5){
                Console.WriteLine("Not Weird");
            }
            
            if(N%2==0 && N >= 6 && N <= 20){
                Console.WriteLine("Weird");
            }

            if(N%2==0 && N > 20){
                Console.WriteLine("Not Weird");
            }
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            solve(N);
        }
    }
}
