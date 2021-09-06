using System;

namespace UppgiftD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett nummer mellan 1-10");
            int antal = Convert.ToInt32(Console.ReadLine());

            int[] sifferbok = new int[antal];
            int sum = 0;
            int max = 0;
            int min = 2333333;

            for (int i = 0; i < antal; i++)
            {
                Console.Write("Skriv en siffra: ");
                sifferbok[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < sifferbok.Length; i++)
            {
                sum = sifferbok[i] + sum;
                if (max < sifferbok[i])
                {
                    max = sifferbok[i];
                }
                if (min > sifferbok[i])
                {
                    min = sifferbok[i];
                }

            }
            int medelvardet = sum / antal;
            Console.WriteLine("Summan är: " + sum);
            Console.WriteLine("Maxvärdet är " + max);
            Console.WriteLine("Minvädet är " + min);
            Console.WriteLine("Medelvärdet är " + medelvardet);
        }
    }
}
