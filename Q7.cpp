#include <iostream>

using namespace std;

int main()
{
    float numero1, numero2;
    cout << "Digite um número: ";
    cin >> numero1;
    cout << "Digite um número diferente: ";
    cin >> numero2;
    if (numero1 > numero2)
    {
        cout << "O maior número é " << numero1 << "." << endl;
    }
    else
    {
        cout << "O maior número é " << numero2 << "." << endl;
    }
    return 0;
}