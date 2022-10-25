#include <iostream>

using namespace std;

int main()
{
    int hora_inicial, hora_final, duracao_dia, duracao_dia_seguinte;
    cout << "Digite em quais horas o jogo de xadrez iniciou: ";
    cin >> hora_inicial;
    cout << "Digite em quais horas o jogo de xadrez terminou: ";
    cin >> hora_final;
    duracao_dia = hora_final - hora_inicial;
    duracao_dia_seguinte = hora_final + 24 - hora_inicial;
    if (hora_inicial < hora_final)
    {
        if (duracao_dia == 1)
        {
            cout << "A duração do jogo de xadrez foi " << duracao_dia << " hora." << endl;
        }
        else
        {
            cout << "A duração do jogo de xadrez foi " << duracao_dia << " horas." << endl;
        }
    }
    else
    {
        if (duracao_dia_seguinte == 1)
        {
            cout << "A duração do jogo de xadrez foi " << duracao_dia_seguinte << " hora." << endl;
        }
        else
        {
            cout << "A duração do jogo de xadrez foi " << duracao_dia_seguinte << " horas." << endl;
        }
    }
    return 0;
}