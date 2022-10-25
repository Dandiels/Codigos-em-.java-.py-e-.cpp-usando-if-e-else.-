import java.text.DecimalFormat;
import java.util.Scanner;

public class Q12 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        float salario_fixo, valor_das_vendas, salario_normal, salario_bonus;
        String salario_normal_formatado, salario_bonus_formatado;
        System.out.print("Digite o salário fixo do vendedor: ");
        salario_fixo = leia.nextFloat();
        System.out.print("Digite o valor das vendas efetuadas pelo vendedor: ");
        valor_das_vendas = leia.nextFloat();
        salario_normal = salario_fixo + valor_das_vendas * 0.03f;
        salario_normal_formatado = new DecimalFormat("#.00").format(salario_normal);
        if (valor_das_vendas <= 1500) 
        {
            System.out.println("O salário total desse vendedor é R$" + salario_normal_formatado + ".");
        } 
        else 
        {
            salario_bonus = salario_fixo + 45 + (valor_das_vendas - 1500) * 0.05f;
            salario_bonus_formatado = new DecimalFormat("#.00").format(salario_bonus);
            System.out.println("O salário total desse vendedor é R$" + salario_bonus_formatado + ".");
        }
    }
}