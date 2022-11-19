using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            float número;
            Console.Write("Digite um número: ");
            número = float.Parse(Console.ReadLine());
            if (número > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }
        }
    }
}