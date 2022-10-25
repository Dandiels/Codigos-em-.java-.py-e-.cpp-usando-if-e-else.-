número1=float(input("Digite um número: "))
número2=float(input("Digite um número diferente: "))
if número1>número2:
    print(f"O maior número é {número1:,.6g}.")
else:
    print(f"O maior número é {número2:,.6g}.")