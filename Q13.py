número_conta=int(input("Digite o número da conta do cliente: "))
saldo=float(input("Digite o saldo do cliente: "))
débito=float(input("Digite o débito do cliente: "))
crédito=float(input("Digite o crédito do cliente: "))
saldo_atual=saldo-débito+crédito
if saldo_atual>=0:
    print(f"Saldo Positivo.")
else:
    print(f"Saldo Negativo.")