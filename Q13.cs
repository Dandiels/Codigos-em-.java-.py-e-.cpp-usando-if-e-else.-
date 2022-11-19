using System;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            int número_conta;
            float saldo, débito, crédito, saldo_atual;
            Console.Write("Digite o número da conta do cliente: ");
            número_conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o saldo do cliente: ");
            saldo = float.Parse(Console.ReadLine());
            Console.Write("Digite o débito do cliente: ");
            débito = float.Parse(Console.ReadLine());
            Console.Write("Digite o crédito do cliente: ");
            crédito = float.Parse(Console.ReadLine());
            saldo_atual = saldo - débito + crédito;
            if (saldo_atual >= 0)
            {
                Console.WriteLine("Saldo Positivo.");
            }
            else
            {
                Console.WriteLine("Saldo Negativo.");
            }
        } 
    }
}