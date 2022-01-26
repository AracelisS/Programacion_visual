print("Digita los numeros")

print("Digita el primer numero: ")
num1=int(input())
print("Digita el siguiente numero: ")
num2=int(input())

while num1 < 0 :
  print("Este numero no es entero")
  num1=int(input("Digita otra vez el numero 1: "))

while num2 < 0:
  print("Este numero no es entero")
  num2=int(input("Digita otra vez el numero2 : "))
