using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        char b = '*';
        for(int i = 0; i < n; i++){     
        Console.Write($"{b}");    
        Console.WriteLine($"{b}");    
        }
        }
    }
}
