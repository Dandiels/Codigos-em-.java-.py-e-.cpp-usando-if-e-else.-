import java.text.DecimalFormat;
import java.util.Scanner;

public class Q5 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        float nota1, nota2, media;
        String media_real;
        System.out.print("Digite a primeira nota do aluno: ");
        nota1 = leia.nextFloat();
        System.out.print("Digite a segunda nota do aluno: ");
        nota2 = leia.nextFloat();
        media = (nota1 + nota2) / 2;
        media_real = new DecimalFormat("#.######").format(media);
        if (media >= 7) 
        {
            System.out.println("O aluno foi aprovado, pois sua média foi " + media_real + ".");
        } 
        else 
        {
            System.out.println("O aluno não foi aprovado, pois sua média foi " + media_real + ".");
        }
    }
}