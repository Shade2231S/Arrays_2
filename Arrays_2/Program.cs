using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    internal class Program
    {
        static int a = 10;
        static int b = 20;
        static int[] score = {50,30,80,100};
        static string[] names = { };
        static void Main(string[] args)
        {
            Console.WriteLine("C# Arrays 2");
            Console.WriteLine("==================");

            for (int i = 0;i < a;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================");

            Console.WriteLine("score1 - " + score[0]);
            Console.WriteLine("score2 - " + score[1]);
            Console.WriteLine("score3 - " + score[2]);
            Console.WriteLine("score4 - " + score[3]);

            Console.WriteLine("==================");



            Console.WriteLine("==================");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
