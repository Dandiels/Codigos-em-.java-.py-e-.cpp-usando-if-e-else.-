using System;

namespace Q8
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
            if (número1 < número2)
            {
                Console.WriteLine("A ordem crescente desses números é {0} e {1}.", número1f, número2f);
            }
            else
            {
                Console.WriteLine("A ordem crescente desses números é {0} e {1}.", número2f, número1f);
            }
        }
    }
}