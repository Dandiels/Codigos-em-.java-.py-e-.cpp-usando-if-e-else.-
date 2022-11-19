using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            float número1, número2;
            String número1f, número2f;
            Console.Write("Digite um número: ");
            número1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um número diferente: ");
            número2 = float.Parse(Console.ReadLine());
            número1f = string.Format("{0:#,#.######}", número1);
            número2f = string.Format("{0:#,#.######}", número2);
            if (número1 > número2)
            {
                Console.WriteLine("O maior número é {0}.", número1f);
            }
            else
            {
                Console.WriteLine("O maior número é {0}.", número2f);
            }
        }
    }
}