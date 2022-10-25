#include <iostream>

using namespace std;

int main()
{
    int codigo_usuario, senha;
    cout << "Digite o código de usuário: ";
    cin >> codigo_usuario;
    if (codigo_usuario == 1234)
    {
        cout << "Digite a senha: ";
        cin >> senha;
        if (senha == 9999)
        {
            cout << "Acesso Permitido." << endl;
        }
        else
        {
            cout << "Senha Incorreta." << endl;
        }
    }
    else
    {
        cout << "Usuário Inválido!" << endl;
    }
    return 0;
}