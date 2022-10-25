#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    float salario_fixo, valor_das_vendas, salario_normal, salario_bonus;
    cout << "Digite o salário fixo do vendedor: ";
    cin >> salario_fixo;
    cout << "Digite o valor das vendas efetuadas pelo vendedor: ";
    cin >> valor_das_vendas;
    salario_normal = salario_fixo + valor_das_vendas * 0.03;
    cout << fixed << setprecision(2);
    if (valor_das_vendas <= 1500)
    {
        cout << "O salário total desse vendedor é R$" << salario_normal << "." << endl;
    }
    else
    {
        salario_bonus = salario_fixo + 45 + (valor_das_vendas - 1500) * 0.05;
        cout << "O salário total desse vendedor é R$" << salario_bonus << "." << endl;
    }
    return 0;
}