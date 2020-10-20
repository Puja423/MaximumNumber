using System;

namespace MaximumNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum number check program.");
            Console.WriteLine("Find max Number");
            MaxNumberCheck MaxInt = new MaxNumberCheck();
            int result = MaxInt.MaximumIntegerNumber(70, 80, 122);
            Console.WriteLine(result);
        }
    }
}