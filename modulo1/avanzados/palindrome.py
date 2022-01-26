print("Texto palindromo")
palabra = input("Ingresa la palabra: ")
if str(palabra) == str(palabra)[::-1] :
    print("Palindrome")
else:
    print("NO es Palindrome")