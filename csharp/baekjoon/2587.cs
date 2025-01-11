using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string input = Console.ReadLine();//프로그램 입력
        string[] parts = input.Split(' ');//띄어쓰기로 나누기
        int a = int.Parse(parts[0]);//첫번째 배열
        int b = int.Parse(parts[1]);//두번째 배열
        int c = int.Parse(parts[2]);//세번째 배열
        int d = int.Parse(parts[3]);//네번째 배열
        int e = int.Parse(parts[4]);//다섯번째 배열
        int f = 1;//중앙 값
        
        

        Console.WriteLine(f);
        Console.WriteLine($"{(a+b+c+d+e)/5}");//평균 값
        }
    }
}
