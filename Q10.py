horas_trabalho=int(input("Digite a quantidade de horas trabalhadas no mês: "))
salário_hora=float(input("Digite o salário ganho por hora trabalhada: "))
salário=horas_trabalho*salário_hora
if horas_trabalho<=40:
    print(f"O salário total do funcionário é R${salário:,.2f}.")
else:
    salário_sem_bônus=40*salário_hora
    horas_extras=horas_trabalho-40
    salário_bônus=horas_extras*(salário_hora*1.5)
    salário_total=salário_sem_bônus+salário_bônus
    print(f"O salário total do funcionário é R${salário_total:,.2f}.")