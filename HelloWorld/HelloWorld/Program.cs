using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { null, null, null };

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("Vad är din favorit rätt?");
                food[i] = Console.ReadLine();
            }

            for (int i = 0; i < food.Length; i++)
            {
                Console.Write(food[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i] + " (" + food[i].Length + ")");
            }

            int length = 0;
            for (int i = 1; i < food.Length; i++)
                if (food[length].Length < food[i].Length)
                {
                    length = i;
                }

            Console.WriteLine("Den längsta maträtten är: " + food[length]);
            Console.ReadLine();
        }
    }
}