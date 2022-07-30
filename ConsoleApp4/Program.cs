using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber, SecondNumber;

            string decision;

            Console.WriteLine("Enter the first number");

            FirstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            SecondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operation: '+', '-', '*', '/' ");

            decision = Console.ReadLine();

            if (decision == "+") 
            {             

                Console.WriteLine(FirstNumber + SecondNumber);
            }

            else if(decision == "-")
            {
             
                Console.WriteLine(FirstNumber - SecondNumber);
            }
            else if(decision == "*")
            {
                

                Console.WriteLine(FirstNumber * SecondNumber);
            }
            else if(decision == "/")
            {

                Console.WriteLine(FirstNumber / SecondNumber);
            }
        }
    }
}
 