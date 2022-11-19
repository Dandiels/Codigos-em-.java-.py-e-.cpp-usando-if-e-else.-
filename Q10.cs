using System;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {    
            byte horas_trabalho, horas_extras;
            float salário_hora, salário, salário_sem_bônus, salário_bônus;
            String saláriof;
            Console.Write("Digite a quantidade de horas trabalhadas no mês: ");
            horas_trabalho = byte.Parse(Console.ReadLine());
            Console.Write("Digite o salário ganho por hora trabalhada: ");
            salário_hora = float.Parse(Console.ReadLine());
            if (horas_trabalho <= 40)
            {
                salário = horas_trabalho * salário_hora;
                saláriof = string.Format("{0:N}", salário);
                Console.WriteLine("O salário total do funcionário é R${0}.", saláriof);
            }
            else
            {
                horas_extras = Convert.ToByte(horas_trabalho - 40);
                salário_sem_bônus = 40 * salário_hora;
                salário_bônus = salário_hora * 1.5f * horas_extras;
                salário = salário_sem_bônus + salário_bônus;
                saláriof = string.Format("{0:N}", salário);
                Console.WriteLine("O salário total do funcionário é R${0}.", saláriof);
            }
        } 
    }
}