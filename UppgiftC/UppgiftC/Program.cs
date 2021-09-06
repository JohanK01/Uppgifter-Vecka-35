using System;

namespace UppgiftC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ge mig en palidrom: ");
            string palidrom = Console.ReadLine();

            Console.WriteLine(palidrom);

            char[] reverse = new char[palidrom.Length];

            palidrom.CopyTo(0, reverse, 0, palidrom.Length);
            Array.Reverse(reverse, 0, reverse.Length);

            Console.WriteLine(reverse);
        }
    }
}