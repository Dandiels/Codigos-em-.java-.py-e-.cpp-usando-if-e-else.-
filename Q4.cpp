#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    int macas;
    cout << "Digite a quantidade de maçãs: ";
    cin >> macas;
    cout << fixed << setprecision(2);
    if (macas < 12)
    {
        cout << "O preço total da compra é R$" << macas * 2.50 << "." << endl;
    }
    else
    {
        cout << "O preço total da compra é R$" << macas * 1.90 << "." << endl;
    }
    return 0;
}