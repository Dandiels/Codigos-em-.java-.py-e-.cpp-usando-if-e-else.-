nota1=float(input("Digite a primeira nota do aluno: "))
nota2=float(input("Digite a segunda nota do aluno: "))
média=(nota1+nota2)/2
if média>=7:
    print(f"O aluno foi aprovado, pois sua média foi {média:.6g}.")
else:
    print(f"O aluno não foi aprovado, pois sua média foi {média:.6g}.")