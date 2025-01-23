using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string a = Console.ReadLine();
        int n = int.Parse(a);
        char b = '*';
            
        for(int i = 0; i < n; i++){//0부터 n-1번까지 반복
     
        for(int x = 0; x < i; x++){
        Console.Write(" ");//공백 출력    
        }        
        for(int z = 0; z < 2 * (n - i) - 1; z++){
        Console.Write(b);//별 출력            
        }

        Console.WriteLine();//줄바꿈
        }
            
        for(int i = 1; i < n; i++){//1부터 n-1번까지 반복
     
        for(int x = 0; x < n - i - 1; x++){
        Console.Write(" ");//공백 출력    
        }        
        for(int z = 0; z < 2 * i + 1; z++){
        Console.Write(b);//별 출력            
        }

        Console.WriteLine();//줄바꿈
        }
        
            }
    }
}
