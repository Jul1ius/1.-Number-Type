using System;

namespace _1._Number_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("negative");
            else if (num > 0)
                Console.WriteLine("positive");
            else if (num == 0)
                Console.WriteLine("zero");
        }
    }
}
