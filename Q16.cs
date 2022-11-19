using System;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            byte homem1, homem2, mulher1, mulher2;
            Console.Write("Digite uma idade para um homem: ");
            homem1 = byte.Parse(Console.ReadLine());
            Console.Write("Digite uma idade diferente para outro homem: ");
            homem2 = byte.Parse(Console.ReadLine());
            Console.Write("Digite uma idade para uma mulher: ");
            mulher1 = byte.Parse(Console.ReadLine());
            Console.Write("Digite uma idade diferente para outra mulher: ");
            mulher2 = byte.Parse(Console.ReadLine());
            if (homem1 > homem2)
            {
                if (mulher1 < mulher2)
                {
                    Console.WriteLine("A soma das idades do homem mais velho e da mulher mais nova é {0}.", homem1 + mulher1);
                    Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é {0}.", homem2 * mulher2);
                }
                else
                {
                    Console.WriteLine("A soma das idades do homem mais velho e da mulher mais nova é {0}.", homem1 + mulher2);
                    Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é {0}.", homem2 * mulher1);
                }
            }
            else
            {
                if (mulher1 < mulher2)
                {
                    Console.WriteLine("A soma das idades do homem mais velho e da mulher mais nova é {0}.", homem2 + mulher1);
                    Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é {0}.", homem1 * mulher2);
                }
                else
                {
                    Console.WriteLine("A soma das idades do homem mais velho e da mulher mais nova é {0}.", homem2 + mulher2);
                    Console.WriteLine("O produto das idades do homem mais novo e da mulher mais velha é {0}.", homem1 * mulher1);
                }
            }
        } 
    }
}