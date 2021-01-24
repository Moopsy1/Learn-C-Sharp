using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //lambda expressions
            //args => experssion
            //number => number*number;
            
            //annonymnous Lambda
            //Console.WriteLine( () => 5*5 );

            
            //assign to delegate. 
            //Func<> takes 0 or more arguments and returns 1 argument
            //Action<> takes 0 or more argumetns and returns void
            //last one is returned
            
            
            Func<int, int> square = number => number*number;
            Console.WriteLine(square(5));   Console.WriteLine("Hello World!");
        }
    }
}
