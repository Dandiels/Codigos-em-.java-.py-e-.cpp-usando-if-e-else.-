using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte maçãs;
            float preço;
            String preçof;
            Console.Write("Digite a quantidade de maçãs: ");
            maçãs = byte.Parse(Console.ReadLine());
            if (maçãs < 12)
            {
                preço = maçãs * 2.50f;
                preçof = string.Format("{0:N}", preço);
                Console.WriteLine("O preço total da compra é R${0}.", preçof);
            }
            else
            {
                preço = maçãs * 1.90f;
                preçof = string.Format("{0:N}", preço);
                Console.WriteLine("O preço total da compra é R${0}.", preçof);
            }
        }
    }
}