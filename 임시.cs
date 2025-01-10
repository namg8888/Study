using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        //배열에 값 5개 키보드입력받아서
        //두번째로 작은 값 출력하는 프로그램
        string input = Console.ReadLine();//프로그램 입력
        string[] parts = input.Split(' ');//띄어쓰기로 나누기
        int a = int.Parse(parts[0]);//첫번째 배열
        int b = int.Parse(parts[1]);//두번째 배열
        int c = int.Parse(parts[2]);//세번째 배열
        int d = int.Parse(parts[3]);//네번째 배열
        int e = int.Parse(parts[4]);//다섯번째 배열
        int f = 1;//가장 작은 수
        int g = 1;//두번째로 작은 수
        
        
            if (a < b && a < c && a < d && a < e){
            f = a; //a가 가장 작다.
            
            if(b < c && b < d && b < e){
            g = b;
            }
            else if(c < d && c < e){
            g = c;    
            }
            else if(d<e){
            g = d;    
            }
            else{
            g = e;    
            }
            }

            else if(b < a && b < c && b < d && b < e){
            f = b; //b가 가장 작다.
                
                if(a < c && a < d && a < e){
                g = a;    
                }
                else if(c < d && c < e){
                g = c;    
                }
                else if(d < e){
                g = d;    
                }
                else{
                g = e;    
                }
                }
            else if(c < a && c < b && c < d && c < e){
            f = c; //c가 가장 작다.
                
                if(a < b && a < d && a < e){
                g = a;   
                }
                else if(b < d && b < e){
                g = b;    
                }
                else if(d < e){
                g = d;    
                }
                else{
                g = e;   
                }
                }
            else if(d < a && d < b && d < c && d < e){
            f = d; //d가 가장 작다.

                if(a < b && a < c && a < e){
                g = a;    
                }
                else if(b < c && b < e){
                g = b;   
                }
                else if(c < e){
                g = c;    
                }
                else{
                g = e;    
                }
                }
            else{
            f = e; //e가 가장 작다.

                if(a < b && a < c && a < d){
                g = a;    
                }
                else if(b < c && b < d){
                g = b;    
                }
                else if(c < d){
                g = c;    
                }
                else{
                g = d;    
                }
                }
        Console.WriteLine(f);//첫번째로 작은 수
        Console.WriteLine(g);//두번째로 작은 수
        }
    }
}
