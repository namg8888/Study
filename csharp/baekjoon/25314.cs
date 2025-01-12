using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        string b = "long";
        string c = "int";  
        for(int i = 0; i< n; i= i+4 ){
        Console.Write($"{b} ");
        }
        Console.WriteLine(c);
        }
        }
    }
