código_usuário=int(input("Digite o código de usuário: "))
if código_usuário==1234:
    senha=int(input("Digite a senha: "))
    if senha==9999:
        print("Acesso Permitido.")
    else:
        print("Senha Incorreta.")
else:
    print("Usuário Inválido!")