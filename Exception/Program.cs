using System;
using My = ExceptionLibrary;

namespace ExceptionProject {
    class Program {

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }

        void Run() {

            
                var ans = My.Math.Add(1, 2);
                ans = My.Math.Sub(ans, 2);
            
                ans = My.Math.Mult(200, ans);
                Console.WriteLine($"Answer Is {ans}");
            

            
                    ans = My.Math.Div(17183, ans);
                    Console.WriteLine($"Answer is {ans}");

               

                   
               


                


        }








            



            
            
         
    }

}