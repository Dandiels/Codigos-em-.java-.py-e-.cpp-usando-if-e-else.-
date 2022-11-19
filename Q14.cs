using System;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            byte quantidade_atual, quantidade_máxima, quantidade_mínima, quantidade_média;
            Console.Write("Digite a quantidade atual em estoque do produto: ");
            quantidade_atual = byte.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade máxima em estoque do produto: ");
            quantidade_máxima = byte.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade mínima em estoque do produto: ");
            quantidade_mínima = byte.Parse(Console.ReadLine());
            quantidade_média = Convert.ToByte((quantidade_máxima + quantidade_mínima) / 2);
            if (quantidade_atual >= quantidade_média)
            {
                Console.WriteLine("Não efetuar compra.");
            }
            else
            {
                Console.WriteLine("Efetuar compra.");
            }
        } 
    }
}