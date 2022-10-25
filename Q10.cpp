#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int horas_trabalho, horas_extras;
    float salario_hora, salario, salario_sem_bonus, salario_bonus, salario_total;
    cout << "Digite a quantidade de horas trabalhadas no mês: ";
    cin >> horas_trabalho;
    cout << "Digite o salário ganho por hora trabalhada: ";
    cin >> salario_hora;
    salario = horas_trabalho * salario_hora;
    cout << fixed << setprecision(2);
    if (horas_trabalho <= 40)
    {
        cout << "O salário total do funcionário é R$" << salario << "." << endl;
    }
    else
    {
        salario_sem_bonus = 40 * salario_hora;
        horas_extras = horas_trabalho - 40;
        salario_bonus = horas_extras * (salario_hora * 1.5);
        salario_total = salario_sem_bonus + salario_bonus;
        cout << "O salário total do funcionário é R$" << salario_total << "." << endl;
    }
    return 0;
}