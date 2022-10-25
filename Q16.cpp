#include <iostream>

using namespace std;

int main()
{
    int homem1, homem2, mulher1, mulher2;
    cout << "Digite uma idade para um homem: ";
    cin >> homem1;
    cout << "Digite uma idade diferente para outro homem: ";
    cin >> homem2;
    cout << "Digite uma idade para uma mulher: ";
    cin >> mulher1;
    cout << "Digite uma idade diferente para outra mulher: ";
    cin >> mulher2;
    if (homem1 > homem2)
    {
        if (mulher1 < mulher2)
        {
            cout << "A soma das idades do homem mais velho e da mulher mais nova é " << homem1 + mulher1 << "." << endl;
            cout << "O produto das idades do homem mais novo e da mulher mais velha é " << homem2 * mulher2 << "." << endl;
        }
        else
        {
            cout << "A soma das idades do homem mais velho e da mulher mais nova é " << homem1 + mulher2 << "." << endl;
            cout << "O produto das idades do homem mais novo e da mulher mais velha é " << homem2 * mulher1 << "." << endl;
        }
    }
    else
    {
        if (mulher1 < mulher2)
        {
            cout << "A soma das idades do homem mais velho e da mulher mais nova é " << homem2 + mulher1 << "." << endl;
            cout << "O produto das idades do homem mais novo e da mulher mais velha é " << homem1 * mulher2 << "." << endl;
        }
        else
        {
            cout << "A soma das idades do homem mais velho e da mulher mais nova é " << homem2 + mulher2 << "." << endl;
            cout << "O produto das idades do homem mais novo e da mulher mais velha é " << homem1 * mulher1 << "." << endl;
        }
    }
    return 0;
}