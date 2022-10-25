import java.util.Scanner;

public class Q9 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int hora_inicial, hora_final, duraçao_dia, duraçao_dia_seguinte;
        System.out.print("Digite em quais horas o jogo de xadrez iniciou: ");
        hora_inicial = leia.nextInt();
        System.out.print("Digite em quais horas o jogo de xadrez terminou: ");
        hora_final = leia.nextInt();
        duraçao_dia = hora_final - hora_inicial;
        duraçao_dia_seguinte = hora_final + 24 - hora_inicial;
        if (hora_inicial < hora_final) 
        {
            if (duraçao_dia == 1) 
            {
                System.out.println("A duração do jogo de xadrez foi " + duraçao_dia + " hora.");
            } 
            else 
            {
                System.out.println("A duração do jogo de xadrez foi " + duraçao_dia + " horas.");
            }
        } 
        else 
        {
            if (duraçao_dia_seguinte == 1) 
            {
                System.out.println("A duração do jogo de xadrez foi " + duraçao_dia_seguinte + " hora.");
            } 
            else 
            {
                System.out.println("A duração do jogo de xadrez foi " + duraçao_dia_seguinte + " horas.");
            }
        }
    }
}