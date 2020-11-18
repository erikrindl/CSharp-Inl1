using System;
using System.Data;

namespace CSharp_Inl1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title = "Inlämningsuppgift 1";
            double doubleResult = 0.0;
            while (true)
            {

                Console.Write(">Enter first operator: ");
                string Op1 = Console.ReadLine();
                Console.Write(">Enter second operator: ");
                string Op2 = Console.ReadLine();
                Console.Write(">Enter first number: ");
                string Num1 = Console.ReadLine();
                Console.Write(">Enter second number: ");
                string Num2 = Console.ReadLine();
                Console.Write(">Enter third number: ");
                string Num3 = Console.ReadLine();

                string calculation = Num1 + Op1 + Num2 + Op2 + Num3;
                string result = new DataTable().Compute(calculation, null).ToString();
                Console.WriteLine(calculation + " = " + result);
                
                double sum = Convert.ToDouble(result);
                doubleResult += sum;

                if (sum < 100)
                {
                    Console.WriteLine("The sum is less than 100.");

                }
                else if (sum > 100)
                {
                    Console.WriteLine("The sum is more than 100.");

                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool! Now you have 100!");

                }

                Console.Write("Another try? (Y/N) ");
                string input = Console.ReadLine();
                string choice = input.ToUpper();

                if (choice == "N" || choice == "NO")
                {
                    Console.WriteLine("Thanks for playing! The sum of all rounds: " + doubleResult + " Bye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                    continue;
            }

        }
    }
}
