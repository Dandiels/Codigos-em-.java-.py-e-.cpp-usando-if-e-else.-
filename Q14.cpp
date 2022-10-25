#include <iostream>

using namespace std;

int main()
{
    int quantidade_atual, quantidade_maxima, quantidade_minima, quantidade_media;
    cout << "Digite a quantidade atual em estoque do produto: ";
    cin >> quantidade_atual;
    cout << "Digite a quantidade máxima em estoque do produto: ";
    cin >> quantidade_maxima;
    cout << "Digite a quantidade mínima em estoque do produto: ";
    cin >> quantidade_minima;
    quantidade_media = (quantidade_maxima + quantidade_minima) / 2;
    if (quantidade_atual >= quantidade_media)
    {
        cout << "Não efetuar compra." << endl;
    }
    else
    {
        cout << "Efetuar compra." << endl;
    }
    return 0;
}
