using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            float número;
            Console.Write("Digite um número: ");
            número = float.Parse(Console.ReadLine());
            if (número >= 0)
            {
                Console.WriteLine("Esse número é positivo.");
            }
            else
            {
                Console.WriteLine("Esse número é negativo.");
            }
        }
    }
}