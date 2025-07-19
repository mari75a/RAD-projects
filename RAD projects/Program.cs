using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_projects
{
    internal class Program
    {

        public static void printStars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("You Entered "+ num);

            for (int i=0;i <10; i++)
            {
                Console.WriteLine("Line "+i);
            }

            printStars(num);
            printMidTriangle(num);
            printReverseTriangle(num);
        }

         public static void printMidTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void printReverseTriangle(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }


    }
}
