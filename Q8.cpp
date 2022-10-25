#include <iostream>

using namespace std;

int main()
{
    float numero1, numero2;
    cout << "Digite um número: ";
    cin >> numero1;
    cout << "Digite um número diferente: ";
    cin >> numero2;
    if (numero1 < numero2)
    {
        cout << "A ordem crescente desses números é " << numero1 << " e " << numero2 << "." << endl;
    }
    else
    {
        cout << "A ordem crescente desses números é " << numero2 << " e " << numero1 << "." << endl;
    }
    return 0;
}