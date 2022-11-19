using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort ano_atual, ano_nascimento, idade;
            Console.Write("Digite o ano atual: ");
            ano_atual = ushort.Parse(Console.ReadLine());
            Console.Write("Digite seu ano de nascimento: ");
            ano_nascimento = ushort.Parse(Console.ReadLine());
            idade = Convert.ToUInt16(ano_atual - ano_nascimento);
            if (idade >= 16)
            {
                Console.WriteLine("Você está apto para votar este ano.");
            }
            else
            {
                Console.WriteLine("Você não está apto para votar este ano.");
            }
        }
    }
}