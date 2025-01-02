using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //변수 선언
        float a,b; 
        a=20;
        b=3;
        //사칙연산 시작
        //덧셈
        //1+1
        Console.WriteLine($"{a}+{b}={a+b}");
        
        //뺄셈
        //3-2
        Console.WriteLine($"{a}-{b}={a-b}");
        //곱셈
        //2*2
        Console.WriteLine($"{a}*{b}={a*b}");
        //나눗셈
        //2/6
        Console.WriteLine($"{a}/{b}={(float)a/b}");
        //나머지 연산
        //2/7
        Console.WriteLine($"{a}%{b}={a%b}");
        
        }
    }
}
