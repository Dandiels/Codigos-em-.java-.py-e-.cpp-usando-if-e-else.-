número1=float(input("Digite um número: "))
número2=float(input("Digite um número diferente: "))
if número1<número2:
    print(f"A ordem crescente desses números é {número1:,.6g} e {número2:,.6g}.")
else:
    print(f"A ordem crescente desses números é {número2:,.6g} e {número1:,.6g}.")