using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //다섯 개의 자연수가 주어질 때 이들의 평균과 중앙값을 구하는 프로그램을 작성하시오.
        //입력 첫째 줄부터 다섯 번째 줄까지 한 줄에 하나씩 자연수가 주어진다. 주어지는 자연수는 100 보다 작은 10의 배수이다.
        //출력 첫째 줄에는 평균을 출력하고, 둘째 줄에는 중앙값을 출력한다. 평균과 중앙값은 모두 자연수이다.
        string input = Console.ReadLine();//프로그램 입력
        string[] parts = input.Split(' ');//띄어쓰기로 나누기
        int a = int.Parse(parts[0]);//첫번째 배열
        int b = int.Parse(parts[1]);//두번째 배열
        int c = int.Parse(parts[2]);//세번째 배열
        int d = int.Parse(parts[3]);//네번째 배열
        int e = int.Parse(parts[4]);//다섯번째 배열
        int f = 970325;//중앙 값
        int[] g = {a, b, c, d, e};
        

        Console.WriteLine(f);
        Console.WriteLine($"{(a+b+c+d+e)/5}");//평균 값
        }
    }
}
