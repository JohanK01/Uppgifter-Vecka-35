using System;

namespace UppgiftB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett citat på minst 5 ord");
            string citat = Console.ReadLine();

            string[] ordbok = new string[99999];
            int ordmangd = 0;

            for (int i = 0; i < citat.Length; i++)
            {
                if (citat[i] == ' ')
                {
                    ordmangd ++;
                }
                else
                {
                    ordbok[ordmangd] += citat[i];
                }
            }
            ordmangd ++;
            Console.WriteLine(ordmangd);

            for (int i = 0; i < ordmangd; i++)
            {
                Console.WriteLine(ordbok[i]);
            }
        }
    }
}
