using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다.
        //같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다.
        //같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다.
        //모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.
        string input = Console.ReadLine();//프로그램 입력
        string[] parts = input.Split(' ');//띄어쓰기로 나누기
        int a = int.Parse(parts[0]);//첫번째 배열
        int b = int.Parse(parts[1]);//두번째 배열
        int c = int.Parse(parts[2]);//세번째 배열
        int d = 1;// 가장 큰 수
        int e = 1;// 겹치는 수
            
        //큰 수 비교
        if(a>b && a>c){//a가 가장 클 때
        d = a;
            }
            else if(b>a && b>c){//b가 가장 클 때
        d = b;
            }
            else if(c>a && c>b){//c가 가장 클 때
        d= c;       
            }
            
        //같은 수 비교
        if(a==b){//첫번째와 두번째 수가 같을 때
        e = a;    
        }
            else if(b==c){//두번째와 세번째 수가 같을 때
        e = b;   
        }
            else if(a==c){//첫번째와 세번째 수가 같을 때
        e = c;    
        }
        
        //계산    
        if(a==b && b==c){//3개의 수가 같다
        Console.WriteLine($"{10000+(e*1000)}");    
        }
            else if(a==b || b==c || a==c ){//2개의 수가 같다
        Console.WriteLine($"{1000+(e*100)}");        
            }
            else if(a!=b && b!=c){//같은 수가 없다.
        Console.WriteLine($"{d*100}");
                }
        } 
    }
}
