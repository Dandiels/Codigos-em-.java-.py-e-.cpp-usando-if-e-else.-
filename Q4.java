import java.text.DecimalFormat;
import java.util.Scanner;

public class Q4 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int maças;
        float preço_menor, preço_maior;
        String preço_menor_reais, preço_maior_reais;
        System.out.print("Digite a quantidade de maçãs: ");
        maças = leia.nextInt();
        preço_menor = maças * 2.50f;
        preço_maior = maças * 1.90f;
        preço_menor_reais = new DecimalFormat("#.00").format(preço_menor);
        preço_maior_reais = new DecimalFormat("#.00").format(preço_maior);
        if (maças < 12) 
        {
            System.out.println("O preço total da compra é R$" + preço_menor_reais + ".");
        } 
        else 
        {
            System.out.println("O preço total da compra é R$" + preço_maior_reais + ".");
        }
    }
}