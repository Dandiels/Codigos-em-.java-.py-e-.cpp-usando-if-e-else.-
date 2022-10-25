import java.util.Scanner;

public class Q3 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        float numero;
        System.out.print("Digite um número: ");
        numero = leia.nextFloat();
        if (numero >= 0) 
        {
            System.out.println("Esse número é positivo.");
        } 
        else 
        {
            System.out.println("Esse número é negativo.");
        }
    }
}