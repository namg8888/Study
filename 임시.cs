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
        int d = int.Parse(parts[2]);//네번째 배열
        int e = int.Parse(parts[2]);//다섯번째 배열
        int f = 10;//가장 작은 수
        int g = 10;//두번째로 작은 수
        
        //가장 작은 수
        if (a<=b && a<=c && a<=d && a<=e){
        f = a;
        if(f>b &&){
            
        }
            else if(){
                
            }
            else if(){
                
            }
            else if(){
                
            }
            else if(){
                
            }

        }
            else if(b<=a && b<=c && b<=d && b<=e){
            f = b;
                 if(){
                     
                 }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
            }
            else if(c<=a && c<=b && c<=d && c<=e){
            f = c; 
                if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
            }
            else if(d<=a && d<=b && d<=c && d<=e){
            f = d;
                 if(){
                     
                 }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
            }
            else if(e<=a && e<=b && e<=c && e<=d){
            f = e;
                 if(){
                     
                 }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
                else if(){
                    
                }
            }
        Console.WriteLine(f);
        }
    }
}
