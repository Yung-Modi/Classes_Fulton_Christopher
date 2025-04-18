using System;

namespace Classes_Fulton_Christopher
{
    class Program
    {

        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            greetings.Welcome();

            Console.WriteLine("What is your name stranger?");
            string userName = Console.ReadLine();

            greetings.Hello(userName);
        }
    }
}