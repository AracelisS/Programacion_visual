print("Numero par o impar")
print("Digita el numero: ")
numero = int(input())
a = int(numero.argv[1])

if a % 2 == 0:
    print('El número', a, 'es par.')
else:
    print('El número', a, 'es impar.')