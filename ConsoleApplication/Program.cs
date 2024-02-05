using System;
// See https://aka.ms/new-console-template for more information
namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };

            static void Method1()
            {
                Console.WriteLine("Gilbert is dead!");Jus
            }

            t1.Start();
        }
    }
}
        


