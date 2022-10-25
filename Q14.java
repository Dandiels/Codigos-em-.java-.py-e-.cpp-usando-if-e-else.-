import java.util.Scanner;

public class Q14 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int quantidade_atual, quantidade_maxima, quantidade_minima, quantidade_media;
        System.out.print("Digite a quantidade atual em estoque do produto: ");
        quantidade_atual = leia.nextInt();
        System.out.print("Digite a quantidade máxima em estoque do produto: ");
        quantidade_maxima = leia.nextInt();
        System.out.print("Digite a quantidade mínima em estoque do produto: ");
        quantidade_minima = leia.nextInt();
        quantidade_media = (quantidade_maxima + quantidade_minima) / 2;
        if (quantidade_atual >= quantidade_media) 
        {
            System.out.println("Não efetuar compra.");
        } 
        else 
        {
            System.out.println("Efetuar compra.");
        }
    }
}