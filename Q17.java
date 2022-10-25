import java.util.Scanner;

public class Q17 
{
    public static Scanner leia = new Scanner(System.in);

    public static void main(String args[]) 
    {
        int codigo_usuario, senha;
        System.out.print("Digite o código de usuário: ");
        codigo_usuario = leia.nextInt();
        if (codigo_usuario == 1234) 
        {
            System.out.print("Digite a senha: ");
            senha = leia.nextInt();
            if (senha == 9999) 
            {
                System.out.println("Acesso Permitido.");
            } 
            else 
            {
                System.out.println("Senha Incorreta.");
            }
        } 
        else 
        {
            System.out.println("Usuário Inválido!");
        }
    }
}