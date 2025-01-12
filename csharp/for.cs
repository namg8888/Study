using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //i : index
        //for(변수 선언; 조건(FALSE가 나오면 stop); 반복문 내용 끝난 후의 동작)
        //for (int i = 0; i < 10; i+=1, i++, i=i+1)세개 모두 같은 의미로 1씩 더함
        //for (int i = 1; i < 10; i*=2) i가 2배가 되도록
        //for (int i = 1; i < 10; i*=2)
        //{
        //    Console.WriteLine(i);
        //}
        //정수 n을 입력 받아서 n개의 변수를 입력 후에
        //n개의 변수를 모두 더하는 프로그램을 만드시오
        //입력 5 3 3 10 15 20
        //출력 51
        string a = Console.ReadLine();//문자열 a는 입력 받은 내용이다.

        int n = int.Parse(a);//정수 n은 정수 a이다.
        int b = 0;// 정수 b는 0으로 초기화 한다.
        
        for(int i = 0; i < n; i++ ){//정수 i를 n만큼 반복한다
        a = Console.ReadLine();// a는 입력 받은 내용이다.
        Console.WriteLine($"{b+int.Parse(a)} = {b} + {int.Parse(a)}");
        b = b + int.Parse(a);//b와 정수 a를 모두 합친다.
        //10 = 10 + 1 + 2 + 3 + 4
        //b는 b + 정수 a이다.
        }
        Console.WriteLine(b);//b를 출력한다.
        }
    }
}
