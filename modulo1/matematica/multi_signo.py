print("Multiplicacion")
print("Diguite el primer valor: ")
numero1 = int(input())
print("Digite el segundo valor: ")
numero2 = int(input())
acu = 0
for multi in range(1,numero2+1,1):
  acu = acu + numero1
print("El resultado es: ", acu)