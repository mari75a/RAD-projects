using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_projects
{
    internal class Program
    {
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

        }
    }
}
