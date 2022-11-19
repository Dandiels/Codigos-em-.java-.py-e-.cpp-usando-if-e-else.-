using System;

namespace Q17
{
    class Program
    {
        static void Main(string[] args)
        {
            int código_usuário, senha;
            Console.Write("Digite o código de usuário: ");
            código_usuário = int.Parse(Console.ReadLine());
            if (código_usuário == 1234)
            {
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
                if (senha == 9999)
                {
                    Console.WriteLine("Acesso Permitido.");
                }
                else
                {
                    Console.WriteLine("Senha Incorreta.");
                }
            }
            else
            {
                Console.WriteLine("Usuário Inválido!");
            }
        }
    }
}