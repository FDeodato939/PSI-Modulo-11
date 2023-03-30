using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exeception = errors that occur during execution

            //try = try some code that is considerede "dangerous"
            //chath = cathches and handles exceptions when thay occur
            //finally = always executes rangardless if exception is caugth or not

            //double divided by zero will result in + or - infinity

            //double x;
            int x; //exemple dividedbyzero
            //double y;
            int y; //exemple dividedbyzero
            double result;

            while (true)// to keep the progrem running
            {
                try
                {
                    Console.WriteLine("Enter number 1: ");
                    //x = Convert.ToDouble(Console.ReadLine());
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter number 2: ");
                    //y = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    result = x / y;

                    Console.WriteLine("result: " + result);
                }
                catch (FormatException e)//Format error
                {
                    Console.WriteLine("Não seja burro e digite apenas numeros");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Você não pode dividir por 0.... burro!");
                }
                catch (Exception e)//some exception that I didn't anticipate
                {
                    Console.WriteLine("Something went wrong: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Thanks for visiting");
                }
                Console.ReadLine();
            }
        }
    }
}