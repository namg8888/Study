using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //각 자료형별 바이트 출력하기
        Console.WriteLine($"{sizeof(char)}");
        Console.WriteLine($"{sizeof(int)}");
        Console.WriteLine($"{sizeof(float)}");
        Console.WriteLine($"{sizeof(double)}");
        
        //문자 다루기
        char a;
        string b, c;
        int d;
        a='b';
        b="apple";
        c="watermelon";
        d= 10;
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Console.WriteLine($"{c}");
        Console.WriteLine($"{a+b+c+d+}");
        

        }
    }
}
