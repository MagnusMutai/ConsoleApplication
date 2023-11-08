using System;
// See https://aka.ms/new-console-template for more information
namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int Result1 = x++;
            Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);

            int y = 10;
            int Result2 = ++y;
            Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);

            Console.ReadKey();
        }
    }

    //Pre - No
    //Sub - x=10
    //E - There is no logical expression to evaluate
    //A Result 1 = x
    //P x++ so x+1 = 11, x = 11

    //Pre - Yes 
    //Sub - y = 11
    //E - Skip as there is no logical expression
    //A  - Result1 = 11
    //P No
}


