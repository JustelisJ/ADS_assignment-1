using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Client client = new Client();
            Console.WriteLine("Enter q to quit");
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Write numbers or + - / *");
            input = Console.ReadLine();
            while (input != "quit")
            {
                client.useToken(input);
                input = Console.ReadLine();
            }
        }
    }
}
