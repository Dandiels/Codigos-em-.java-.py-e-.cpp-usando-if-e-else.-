#include <iostream>

using namespace std;

int main()
{
    int numero_conta;
    float saldo, debito, credito, saldo_atual;
    cout << "Digite o número da conta do cliente: ";
    cin >> numero_conta;
    cout << "Digite o saldo do cliente: ";
    cin >> saldo;
    cout << "Digite o débito do cliente: ";
    cin >> debito;
    cout << "Digite o crédito do cliente: ";
    cin >> credito;
    saldo_atual = saldo - debito + credito;
    if (saldo_atual >= 0)
    {
        cout << "Saldo Positivo." << endl;
    }
    else
    {
        cout << "Saldo Negativo." << endl;
    }
    return 0;
}