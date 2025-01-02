using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string input = Console.ReadLine();
        int space = input.IndexOf(' ');
        int a, b;
        string a1 = input.Substring(0, space);  // 첫 번째 숫자
        string b1 = input.Substring(space + 1);  // 두 번째 숫자
        a = int.Parse(a1);
        b = int.Parse(b1);
        Console.WriteLine($"{a+b}");
        Console.WriteLine($"{a-b}");
        Console.WriteLine($"{a*b}");
        Console.WriteLine($"{a/b}");
        Console.WriteLine($"{a%b}");
        
        }
    }
}
