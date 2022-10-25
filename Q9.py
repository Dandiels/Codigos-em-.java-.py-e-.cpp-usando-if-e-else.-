hora_inicial=int(input("Digite em quais horas o jogo de xadrez iniciou: "))
hora_final=int(input("Digite em quais horas o jogo de xadrez terminou: "))
duração_dia=hora_final-hora_inicial
duração_dia_seguinte=hora_final+24-hora_inicial
if hora_inicial<hora_final:
    if duração_dia==1:
        print(f"A duração do jogo de xadrez foi {duração_dia} hora.")
    else:
        print(f"A duração do jogo de xadrez foi {duração_dia} horas.")
else:
    if duração_dia_seguinte==1:
        print(f"A duração do jogo de xadrez foi {duração_dia_seguinte} hora.")
    else:
        print(f"A duração do jogo de xadrez foi {duração_dia_seguinte} horas.")