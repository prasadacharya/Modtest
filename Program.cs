using System;

namespace ModTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;

            int result = (a - b * (a / b));

            Console.WriteLine(result);
        }
    }
}