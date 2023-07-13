using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day04
            //ASSIGNMENT 04
            //decision making constructs and conditional operators
            again:
            Console.WriteLine("Enter a Number:");
            int num=int.Parse(Console.ReadLine());
            //implementing decision making constructs
            if (num >0) {
                Console.WriteLine("The number is positive");
            }else if (num <0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }

            //conditional operator
            string eveodd = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " +  eveodd );
            goto again;
            Console.ReadKey();
        }
    }
}
