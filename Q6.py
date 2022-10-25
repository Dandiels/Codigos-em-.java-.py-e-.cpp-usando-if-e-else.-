ano_atual=int(input("Digite o ano atual: "))
ano_nascimento=int(input("Digite seu ano de nascimento: "))
idade=ano_atual-ano_nascimento
if idade>=16:
    print("Você está apto para votar este ano.")
else:
    print("Você não está apto para votar este ano.")