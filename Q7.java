import java.text.DecimalFormat;
import java.util.Scanner;

public class Q7 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        float numero1, numero2;
        String numero1_formatado, numero2_formatado;
        System.out.print("Digite um número: ");
        numero1 = leia.nextFloat();
        System.out.print("Digite um número diferente: ");
        numero2 = leia.nextFloat();
        numero1_formatado = new DecimalFormat("#.######").format(numero1);
        numero2_formatado = new DecimalFormat("#.######").format(numero2);
        if (numero1 > numero2) 
        {
            System.out.println("O maior número é " + numero1_formatado + ".");
        } 
        else 
        {
            System.out.println("O maior número é " + numero2_formatado + ".");
        }
    }
}
