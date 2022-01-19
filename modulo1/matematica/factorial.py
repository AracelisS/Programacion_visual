print("Factorial de un numero")
print("Digita el numero : ")
numero1 = int(input())
def factorial(numero1):
  if(numero1==0):
    return 1
  else:
    return numero1 * factorial(numero1-1)
print("El factorial de ", str(numero1),"es:", str(factorial (numero1)))