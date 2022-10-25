import java.util.Scanner;

public class Q6 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int ano_atual, ano_nascimento, idade;
        System.out.print("Digite o ano atual: ");
        ano_atual = leia.nextInt();
        System.out.print("Digite seu ano de nascimento: ");
        ano_nascimento = leia.nextInt();
        idade = ano_atual - ano_nascimento;
        if (idade >= 16) 
        {
            System.out.println("Você está apto para votar este ano.");
        } 
        else 
        {
            System.out.println("Você não está apto para votar este ano.");
        }
    }
}