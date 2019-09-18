using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=T; i++){
            string S = Console.ReadLine();
            public char[] SS = S.ToCharArray();
            
            for(int j = 0; j < SS.length()-1; j++){
                if(SS[j]%2==0){
                // Print each sequential character on the same line
                Console.WriteLine(S[j]); 
                }
            }
            Console.WriteLine(" ");
            for(int j = 0; j < SS.length()-1; j++){
                if(SS[j]%2!=0){
                // Print each sequential character on the same line
                Console.WriteLine(S[j]); 
                }
            }

        }
    }
}

