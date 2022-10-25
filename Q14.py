quantidade_atual=int(input("Digite a quantidade atual em estoque do produto: "))
quantidade_máxima=int(input("Digite a quantidade máxima em estoque do produto: "))
quantidade_mínima=int(input("Digite a quantidade mínima em estoque do produto: "))
quantidade_média=int((quantidade_máxima+quantidade_mínima)/2)
if quantidade_atual>=quantidade_média:
    print("Não efetuar compra.")
else:
    print("Efetuar compra.")