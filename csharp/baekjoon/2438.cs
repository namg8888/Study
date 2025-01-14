using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        char b = '*';
        for(int i = 1; i <= n; i++){     
        for(int z = 0; z < i; z++){
        Console.Write($"{b}");
            
        }//이차 for
            Console.WriteLine();
        }//일차 for
        
            }
    }
}
