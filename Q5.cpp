#include <iostream>

using namespace std;

int main()
{
    float nota1, nota2, media;
    cout << "Digite a primeira nota do aluno: ";
    cin >> nota1;
    cout << "Digite a segunda nota do aluno: ";
    cin >> nota2;
    media = (nota1 + nota2) / 2;
    if (media >= 7)
    {
        cout << "O aluno foi aprovado, pois sua média foi " << media << "." << endl;
    }
    else
    {
        cout << "O aluno não foi aprovado, pois sua média foi " << media << "." << endl;
    }
    return 0;
}