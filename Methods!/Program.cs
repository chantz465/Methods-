using System;

namespace Methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User());
            Console.WriteLine("Hello may I get your name?");
            string name = Console.ReadLine();

            Console.WriteLine(ColorChoice(name));
            Console.WriteLine(AnimalChoice());
            //Console.WriteLine(allInputs());


            

            
            

         //   Console.WriteLine(name + " nice to meet you can I can ask what your favorite color is?");
            //string color = Console.ReadLine();

            //if(color == "blue");

            //{
            //    Console.WriteLine(" Thats awsome my favoite color is blue too!");
            //}

            //if(color != "blue")
            //{
            //    Console.WriteLine(" that's an okay color but I perfer blue so we will have to disagree");
                   
            //}


            //Console.WriteLine(" Now that we are getting to know eachother what's your favorite animal?");
            //    string animal = Console.ReadLine();

            //Console.WriteLine(" Great to recap all that I have learned about you is your name is " + name + " and your color of choice is " + color + " and your sprit animal is a " + animal);
            


        }

        //public static string User()
        //{
        //    Console.WriteLine("Hello may I get your name?");
        //    string name = Console.ReadLine();
        //    return name;





        //}

        public static string ColorChoice(string name)

        {
            Console.WriteLine(name + " nice to meet you can I can ask what your favorite color is?");
            string color = Console.ReadLine();
            return color;

        }


        public static string AnimalChoice()

        {
            Console.WriteLine(" Now that we are getting to know eachother what's your favorite animal?");
            string animal = Console.ReadLine();
            return animal;
        }


        //public static string allInputs()

        //{

        //    Console.WriteLine();
        //    string inputs =
        //    return inputs



        //}




    }
}
