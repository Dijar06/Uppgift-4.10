using System;

namespace Uppgift4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hur många O per grupp?");
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int om = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int rad = int.Parse(Console.ReadLine());

            for (int i = 0; i < rad; i++)
            {
                for (int j = 0; j < om; j++)
                {
                    for (int k = 0; k < x; k++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-");
                    for (int l = 0; l < o; l++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                Console.WriteLine();
            } 
        }
    }
}