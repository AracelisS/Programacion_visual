print("Digita tu nombre: ")
nombre= input()
print("Cual es tu edad: ")
edad = int(input())

while edad < 1 or edad > 120:
  print("Digita tu edad: ")
  edad = int(input())


print("Digita el primer numero: ")
num1=int(input())
print("Digita el siguiente numero: ")
num2=int(input())
suma= 1
resta= 2
division= 3
multi= 4
print("Las opciones que hay son: ")
print("1.suma \n","2.resta\n", "3.division \n", "4.multiplicacion \n" )

operacion=int(input("operacion deseada: "))
while operacion < 1 or operacion > 4:
  print("Digita la operacion nueva vez: ")
  operacion=int(input())
if operacion == suma:
  suma= num1+num2
  print("La suma de",num1, "y", num2, "es:", suma)

if operacion == resta:
  resta= num1-num2
  print("La resta de",num1, "y", num2, "es:", resta)
-----------------------
if operacion == division:
  division= num1//num2
  print("La division de",num1, "y", num2, "es:", division)
elif num2 ==0:
  print("La division no se puede ejecutar, debido a que todo numero dividido entre 0 da 0")


--------------------


if operacion == multi:
  multi= num1*num2
  print("La multiplicacion de",num1, "y", num2, "es:", multi)









