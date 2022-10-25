#include <iostream>

using namespace std;

int main()
{
    float numero;
    cout << "Digite um número: ";
    cin >> numero;
    if (numero >= 0)
    {
        cout << "Esse número é positivo." << endl;
    }
    else
    {
        cout << "Esse número é negativo." << endl;
    }
    return 0;
}