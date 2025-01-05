using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        // and 는 %% or은 ||
        
        //1. a를 입력한다
        //2. a가 20보다 작고 3의 배수이면 "find number!" 출력
        //3. a가 20보다 작거나 3의배수이면 "similar number!"
        //4. a가 20보다 크면 "not number :(" 출력
        string input = Console.ReadLine();
        int a;
        string a1 = input.Substring(0);
        a = int.Parse(a1);
        
        if(a<20 && a%3==0){
        Console.WriteLine("find number!");
        }
            else if(a<20 || a%3==0){
        Console.WriteLine("similar number!");        
            }
            else{
        Console.WriteLine("not number");  
            }
        }
    }
}
