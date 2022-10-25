import java.text.DecimalFormat;
import java.util.Scanner;

public class Q10 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int horas_trabalho, horas_extras;
        float salario_hora, salario, salario_sem_bonus, salario_bonus, salario_total;
        String salario_formatado, salario_total_formatado;
        System.out.print("Digite a quantidade de horas trabalhadas no mês: ");
        horas_trabalho = leia.nextInt();
        System.out.print("Digite o salário ganho por hora trabalhada: ");
        salario_hora = leia.nextFloat();
        salario = horas_trabalho * salario_hora;
        if (horas_trabalho <= 40) 
        {
            salario_formatado = new DecimalFormat("#.00").format(salario);
            System.out.println("O salário total do funcionário é R$" + salario_formatado + ".");
        } 
        else 
        {
            salario_sem_bonus = 40 * salario_hora;
            horas_extras = horas_trabalho - 40;
            salario_bonus = horas_extras * (salario_hora * 1.5f);
            salario_total = salario_sem_bonus + salario_bonus;
            salario_total_formatado = new DecimalFormat("#.00").format(salario_total);
            System.out.println("O salário total do funcionário é R$" + salario_total_formatado + ".");
        }
    }
}