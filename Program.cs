using System;

namespace ModTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 122;
            int b = 13;
            

            int result = (a - b * (a / b));

            Console.WriteLine(result);
        }
    }
}