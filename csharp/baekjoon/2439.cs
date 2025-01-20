using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        char b = '*';
        for(int i = 1; i <= n; i++){//1부터 n번까지 반복
     
        for(int x = 0; x < n - i; x++){//n-1만큼 반복
        Console.Write(" ");//공백 출력    
        }        
        for(int z = 0; z < i; z++){//i번 반복
        Console.Write(b);//별 출력
            
        }

        Console.WriteLine();//줄바꿈
        }
        
            }
    }
}
