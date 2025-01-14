using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        char b = '*';
        int y = 0
        for(int i = 1; i <= n; i++){     
        for(int x = ; x >= i; x--){
        Console.Write(" ");    
        }        
        for(int z = 0; z < i; z++){
        Console.Write(b);
            
        }

        Console.WriteLine();
        }
        
            }
    }
}
