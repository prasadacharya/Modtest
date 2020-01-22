using System;

namespace ModTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 88;
            int b = 9;
            

            int result = (a - b * (a / b));

            Console.WriteLine(result);
        }
    }
}