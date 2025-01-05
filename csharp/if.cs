using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        string input = Console.ReadLine();
        int a;
        string a1 = input.Substring(0);
        a = int.Parse(a1);
        
        if(a<10){
            Console.WriteLine("10 than smaller.");
        }
            else if(a==10){//=가 하나면 대입 ==두개면 비교
                Console.WriteLine("a equal 10.");
            }
            else{
                Console.WriteLine("10than bigger.");
            }
        }
    }
}
