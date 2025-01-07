using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다.
        //같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다.
        //같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다.
        //모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.
        string input = Console.ReadLine();
        int space = input.IndexOf(' ');
        int space1 = input.IndexOf(' ');
        int a, b, c, d;
        string a1 = input.Substring(0);
        string b1 = input.Substring(2);
        a = int.Parse(a1);
        b = int.Parse(b1);
        c = int.Parse(c1);
        if(a>b && a>c){
        d = a;
            }
            else if(b>a && b>c){
        d = b;
            }
            else if(c>a && c>b){
        d= c;       
            }
            
        if(a==b && b==c){
        Console.WriteLine($"{10000+(d*1000)}");    
        }
            else if(a==b || b==c || a==c){
        Console.WriteLine($"{1000+(d*100)}");        
            }
            else if(a!=b && b!=c){
        Console.WriteLine($"{d*100}");
                }
        } 
        // 같은 눈이 무엇인지 판별 못함
        // a,b,c중에서 가장 큰 값이 무엇인지 판별 못함
    }
}
