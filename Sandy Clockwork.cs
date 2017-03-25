using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', 2 * n + 1));
            Console.WriteLine();
            Console.Write(new string('.', 1));
            Console.Write(new string('*', 1));
            Console.Write(new string(' ', 2*n+1-4));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', 1));
            Console.WriteLine();
            int j = (2 * n) + 1 - 6;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(new string('.', i+1));
                Console.Write(new string('*', 1));
                Console.Write(new string('@', j));
                j = j - 2;
                Console.Write(new string('*', 1));
                Console.Write(new string('.', i + 1));
                Console.WriteLine();
            }
            Console.Write(new string('.', n));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', n));
            Console.WriteLine();
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(new string('.', n-i));
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i - 1));
                Console.Write(new string('@',1));
                Console.Write(new string(' ', i-1));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
            Console.Write(new string('.', 1));
            Console.Write(new string('*', 1));
            Console.Write(new string('@', 2 * n + 1 - 4));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', 1));
            Console.WriteLine();
            Console.Write(new string('*', n*2+1));




            //int n1 = int.Parse(Console.ReadLine());
        }
    }
}
