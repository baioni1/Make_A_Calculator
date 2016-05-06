using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            string Operator = Console.ReadLine();
            Console.WriteLine("Enter Another Number:");
            int n2 = int.Parse(Console.ReadLine());
            switch(Operator)
            {
                case "+":
                    Console.WriteLine(n1 + n2);
                    break;
                case "-":
                    Console.WriteLine(n1 - n2);
                    break;
                case "*":
                    Console.WriteLine(n1 * n2);
                    break;
                case "/":
                    Console.WriteLine(n1 / n2);
                    break;
                case "%":
                    Console.WriteLine(n1 % n2);
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(n1, n2));
                    break;
                default:
                    Console.WriteLine("Not an Operator, Please try again!");
                    break;



                

            }



        }
    }
}
