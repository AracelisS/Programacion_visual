#Hacer un programa que me pida mi edad... no permitir que sea menor de edad y poner al final bienvenido

print("Cual es tu edad: ")
edad= int(input())

while edad < 18:
  print("Digita tu edad: ")
  edad = int(input())

print("edad aceptada")

if edad >= 18:
 
  print("A que bar te gustaria ir")
  bar=input()
 
else:
  print("Eres menor de edad, espera a tener la mayoria de edad")
print("Bienvenido")
