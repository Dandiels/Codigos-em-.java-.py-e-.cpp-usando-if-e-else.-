salário_fixo=float(input("Digite o salário fixo do vendedor: "))
valor_das_vendas=float(input("Digite o valor das vendas efetuadas pelo vendedor: "))
salário_normal=salário_fixo+valor_das_vendas*0.03
if valor_das_vendas<=1500:
    print(f"O salário total desse vendedor é R${salário_normal:,.2f}.")
else:
    salário_bônus=salário_fixo+45+(valor_das_vendas-1500)*0.05
    print(f"O salário total desse vendedor é R${salário_bônus:,.2f}.")