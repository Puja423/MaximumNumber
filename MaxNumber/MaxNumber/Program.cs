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
            int result = MaxInt.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(result);
            float floatresult = MaxInt.MaximumFloatNumber(186.8f,100.00f,457.28f);
            Console.WriteLine(floatresult);
        }
    }
}
