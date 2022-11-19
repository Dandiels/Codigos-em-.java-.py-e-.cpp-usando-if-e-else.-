using System;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            float salário_fixo, valor_das_vendas, salário;
            String saláriof;
            Console.Write("Digite o salário fixo do vendedor: ");
            salário_fixo = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor das vendas efetuadas pelo vendedor: ");
            valor_das_vendas = float.Parse(Console.ReadLine());
            if (valor_das_vendas <= 1500)
            {
                salário = salário_fixo + valor_das_vendas * 0.03f;
                saláriof = string.Format("{0:N}", salário);
                Console.WriteLine("O salário total do vendedor é R${0}.", saláriof);
            }
            else
            {
                salário = salário_fixo + 45 + (valor_das_vendas - 1500) * 0.05f;
                saláriof = string.Format("{0:N}", salário);
                Console.WriteLine("O salário total do vendedor é R${0}.", saláriof);
            }
        } 
    }
}