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
            factorial(num);

            int[] arr = { 1, 2, 3, 4, 5 };
            SumElements(arr);
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


        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + n + " is " + fact);
        }

        public static void SumElements(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Sum of elements: " + sum);
        }

    }

   
}
