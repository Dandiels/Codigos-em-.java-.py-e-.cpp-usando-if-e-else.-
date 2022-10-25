import java.util.Scanner;

public class Q13 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int numero_conta;
        float saldo, debito, credito, saldo_atual;
        System.out.print("Digite o número da conta do cliente: ");
        numero_conta = leia.nextInt();
        System.out.print("Digite o saldo do cliente: ");
        saldo = leia.nextFloat();
        System.out.print("Digite o débito do cliente: ");
        debito = leia.nextFloat();
        System.out.print("Digite o crédito do cliente: ");
        credito = leia.nextFloat();
        saldo_atual = saldo - debito + credito;
        if (saldo_atual >= 0) 
        {
            System.out.println("Saldo Positivo.");
        } 
        else 
        {
            System.out.println("Saldo Negativo.");
        }
    }
}