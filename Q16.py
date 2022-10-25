homem1=int(input("Digite uma idade para um homem: "))
homem2=int(input("Digite uma idade diferente para outro homem: "))
mulher1=int(input("Digite uma idade para uma mulher: "))
mulher2=int(input("Digite uma idade diferente para outra mulher: "))
if homem1>homem2:
    if mulher1<mulher2:
        print(f"A soma das idades do homem mais velho e da mulher mais nova é {homem1+mulher1}.")
        print(f"O produto das idades do homem mais novo e da mulher mais velha é {homem2*mulher2}.")
    else:
        print(f"A soma das idades do homem mais velho e da mulher mais nova é {homem1+mulher2}.")
        print(f"O produto das idades do homem mais novo e da mulher mais velha é {homem2*mulher1}.")
else:
    if mulher1<mulher2:
        print(f"A soma das idades do homem mais velho e da mulher mais nova é {homem2+mulher1}.")
        print(f"O produto das idades do homem mais novo e da mulher mais velha é {homem1*mulher2}.")
    else:
        print(f"A soma das idades do homem mais velho e da mulher mais nova é {homem2+mulher2}.")
        print(f"O produto das idades do homem mais novo e da mulher mais velha é {homem1*mulher1}.")