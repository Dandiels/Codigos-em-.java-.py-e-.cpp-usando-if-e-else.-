maçãs=int(input("Digite a quantidade de maçãs compradas: "))
if maçãs<12:
    print(f"O preço total da compra é R${maçãs*2.50:,.2f}.")
else:
    print(f"O preço total da compra é R${maçãs*1.90:,.2f}.")