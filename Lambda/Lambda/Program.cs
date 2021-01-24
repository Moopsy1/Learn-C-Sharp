using System.Collections.Generic;
using System;

namespace Lambda
{
    class Program
    {
    public static bool greaterThanFiveMethod(int i){return  i> 5;}
        static void Main(string[] args)
        {
         
            //lambda expressions
            //args => experssion
            // () => ...
            // x => ...
            // (x, y, z) => 
            //number => number*number;

            const int Factor = 5;
            //assign to delegate mult 
            //Func<> takes 0 or more arguments and returns 1 argument
            Func<int, int> mult = n => n*Factor;
            Console.WriteLine(mult(4));

            var List = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            Func<int, bool> greaterThanFive =  i => i > 5;
            foreach (var item in List)
            {
                Console.WriteLine(item + " is greater than 5: " + greaterThanFive(item));
            }

            //Predicate: returns abool value to check if a condition is satisfied
            //lambda function from method
            Func<int , bool> greaterThanFiveMethodLambda = i => Program.greaterThanFiveMethod(i);
            
          foreach (var item in List)
            {
                Console.WriteLine(item + " is greater than 5: " + greaterThanFiveMethodLambda(item));
            }

            //annon lambda method
            var List2 = List.FindAll(T => T > 5);
            foreach (var item in List2)
            {
                Console.WriteLine(item);
            }

            //Action<> takes 0 or more argumetns and returns void
            //last one is returned
                
        }


    }
}
