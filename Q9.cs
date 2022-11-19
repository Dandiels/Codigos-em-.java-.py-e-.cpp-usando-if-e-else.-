using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte hora_inicial, hora_final, duração_dia;
            Console.Write("Digite em quais horas o jogo de xadrez iniciou: ");
            hora_inicial = byte.Parse(Console.ReadLine());
            Console.Write("Digite em quais horas o jogo de xadrez terminou: ");
            hora_final = byte.Parse(Console.ReadLine());
            if (hora_inicial < hora_final)
            {
                duração_dia = Convert.ToByte(hora_final - hora_inicial);
                if (duração_dia == 1)
                {
                    Console.WriteLine("A duração do jogo de xadrez foi {0} hora.", duração_dia);
                }
                else
                {
                    Console.WriteLine("A duração do jogo de xadrez foi {0} horas.", duração_dia);
                }
            }
            else
            {
                duração_dia = Convert.ToByte(hora_final + 24 - hora_inicial);
                if (duração_dia == 1)
                {
                    Console.WriteLine("A duração do jogo de xadrez foi {0} hora.", duração_dia);
                }
                else
                {
                    Console.WriteLine("A duração do jogo de xadrez foi {0} horas.", duração_dia);
                }
            }
        }
    }
}