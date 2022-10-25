#include <iostream>

using namespace std;

int main()
{
    int ano_atual, ano_nascimento, idade;
    cout << "Digite o ano atual: ";
    cin >> ano_atual;
    cout << "Digite seu ano de nascimento: ";
    cin >> ano_nascimento;
    idade = ano_atual - ano_nascimento;
    if (idade >= 16)
    {
        cout << "Você está apto para votar este ano." << endl;
    }
    else
    {
        cout << "Você não está apto para votar este ano." << endl;
    }
    return 0;
}