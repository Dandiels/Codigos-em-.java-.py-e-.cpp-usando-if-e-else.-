import java.util.Scanner;

public class Q16 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int homem1, homem2, mulher1, mulher2;
        System.out.print("Digite uma idade para um homem: ");
        homem1 = leia.nextInt();
        System.out.print("Digite uma idade diferente para outro homem: ");
        homem2 = leia.nextInt();
        System.out.print("Digite uma idade para uma mulher: ");
        mulher1 = leia.nextInt();
        System.out.print("Digite uma idade diferente para outra mulher: ");
        mulher2 = leia.nextInt();
        if (homem1 > homem2) 
        {
            if (mulher1 < mulher2) 
            {
                System.out.println("A soma das idades do homem mais velho e da mulher mais nova é " + (homem1 + mulher1) + ".");
                System.out.println("O produto das idades do homem mais novo e da mulher mais velha é " + homem2 * mulher2 + ".");
            } 
            else 
            {
                System.out.println("A soma das idades do homem mais velho e da mulher mais nova é " + (homem1 + mulher2) + ".");
                System.out.println("O produto das idades do homem mais novo e da mulher mais velha é " + homem2 * mulher1 + ".");
            }
        } 
        else 
        {
            if (mulher1 < mulher2) 
            {
                System.out.println("A soma das idades do homem mais velho e da mulher mais nova é " + (homem2 + mulher1) + ".");
                System.out.println("O produto das idades do homem mais novo e da mulher mais velha é " + homem1 * mulher2 + ".");
            } 
            else 
            {
                System.out.println("A soma das idades do homem mais velho e da mulher mais nova é " + (homem2 + mulher2) + ".");
                System.out.println("O produto das idades do homem mais novo e da mulher mais velha é " + homem1 * mulher1 + ".");
            }
        }
    }
}