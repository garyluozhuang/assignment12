using System;

namespace HelloWorld
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }


        static public string GetMessage()
        {
            return "Hello, World!";
        }
    }
}
