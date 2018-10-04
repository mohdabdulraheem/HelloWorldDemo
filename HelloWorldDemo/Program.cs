using System;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your name ?");
            string name=Console.ReadLine();
            Console.WriteLine("Hello, {0} ",name);
            Console.ReadKey();
        }
    }
}
