#Hacer un algoritmo que me deje digitar (NOMBRE,EDAD Y DOS NUMEROS). Mostrar una lista de las 4 operaciones basicas(+,-,//,*) con un numero correspondiente del 1 - 4. Asi teniendo la opcion de elegir la operacion preferida para calcular los dos numeros e imprimirlos.Ejemplo de como se deberia de ver la imprecion: (La resta de 10 y 5 es igual a 5).

#Debemos tener en cuenta la validacion: Donde la edad sea del 1 al 120.El usuario solo puede digitar una opcion del 1 al 4 para poder elegir la operacion deseada. Y en la parte de la division el usuario no puede digitar 0 en el segundo numero, lo que debemos explicarle el porque no se puede hacer el calculo en un mensaje, de ser digitado el 0.


print("Autor: \n" "Aracelis Severino")

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



  

if operacion == division:
  if num2 ==0:
    print("La operacion no puede ser completada, debido a que todo dividido entre 0 da 0.")
  else:
    division= num1//num2
    print("La division de",num1, "y", num2, "es:", division)




if operacion == multi:
  multi= num1*num2
  print("La multiplicacion de",num1, "y", num2, "es:", multi)
print("Culminacion de programa")








