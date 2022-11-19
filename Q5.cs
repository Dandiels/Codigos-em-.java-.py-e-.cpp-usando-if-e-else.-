using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, média;
            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = float.Parse(Console.ReadLine());
            média = (nota1 + nota2) / 2;
            if (média >= 7)
            {
                Console.WriteLine("O aluno foi aprovado, pois sua média foi {0}.", média);
            }
            else
            {
                Console.WriteLine("O aluno não foi aprovado, pois sua média foi {0}.", média);
            }
        }
    }
}