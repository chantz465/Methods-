using System;

namespace Exercis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = Console.ReadLine();

            var result = Add(10, 20);

        }


        public static int Add(int num1, int num2)

        {
            var sum = num1 + num2;
            return sum;


        }

        public static int Multiply(int num1, int num2)

        {
            var times = num1 * num2;
            return times;

        }










    }
}
