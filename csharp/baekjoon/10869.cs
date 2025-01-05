using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        
        //

        string input = Console.ReadLine();//프로그램 입력을 활성화하기
        int space = input.IndexOf(' ');// 프로그램 입력에서 공백을 제외
        int a, b;
        string a1 = input.Substring(0, space);  // 첫 번째 숫자 입력
        string b1 = input.Substring(space + 1);  // 두 번째 숫자 입력
        a = int.Parse(a1);// 입력 받은 첫번째 숫자를 int로 변환
        b = int.Parse(b1);// 입력 받은 두번째 숫자를 int로 변환
        Console.WriteLine($"{a+b}"); 
        Console.WriteLine($"{a-b}");
        Console.WriteLine($"{a*b}");
        Console.WriteLine($"{a/b}");
        Console.WriteLine($"{a%b}");
        
        }
    }
}
