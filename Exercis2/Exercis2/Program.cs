using System;

namespace Exercis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Hello what is your name?");

            //var name = Console.ReadLine();

            Console.WriteLine("give me two numbers plase");
            string num11 = Console.ReadLine();
            String num22 = Console.ReadLine();


            int num1 = Convert.ToInt32(num11);
            int num2 = Convert.ToInt32(num22);

            Console.WriteLine(Add(num1 , num2));
            Console.WriteLine(Multiply(num1, num2));




        }


        public static int Add(int num1, int num2)

        {
            var sum = num1 + num2;
            Console.WriteLine(sum);
            return sum;


        }

        public static int Multiply(int num1, int num2)

        {
            var times = num1 * num2;
            Console.WriteLine(times);   
            return times;

        }










    }
}
