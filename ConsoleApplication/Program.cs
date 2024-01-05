using System;
// See https://aka.ms/new-console-template for more information
namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statements1");

            goto statement4;
            Console.WriteLine("Statements2");
            Console.WriteLine("Statements3");

            statement4:
            Console.WriteLine("Statements4");
            Console.WriteLine("Statements5");

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

//The process of catching exception by converting CLR given exception message to human understable message
//and by stopping abnormal termination of the program is called exception handling

    //we catch exceptions in two ways simultaneously  1. Converting CLR given message to human understable message.
    //                                                2. Stopping abnormal termination of the program.
    //    All this is called exception handling.
    //    So exception handling is the catching of exceptions by converting CLR given messages to human understandlable messages
    //    and catching of exceptions by stopping the abnormal termination of the program.
}


