using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string input = Console.ReadLine();//프로그램 입력 생성
        char a;//a는 char 선언
        string a1 = input.Substring(0);
        a = char.Parse(a1);//char화
        Console.WriteLine($"{(int)a}");//문자 앞에 int는 문자를 아스키코드화
    
        }
    }
}
