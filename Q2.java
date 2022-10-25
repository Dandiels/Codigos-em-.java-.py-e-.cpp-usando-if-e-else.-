import java.util.Scanner;

public class Q2 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        float numero;
        System.out.print("Digite um número: ");
        numero = leia.nextFloat();
        if (numero > 10) 
        {
            System.out.println("É MAIOR QUE 10!");
        } 
        else 
        {
            System.out.println("NÃO É MAIOR QUE 10!");
        }
    }
}