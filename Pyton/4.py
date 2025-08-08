import math
A=int(input('Ingrese el valor de Cateto A:'))
B=int(input('Ingrese el valor de Cateto B:'))
H=0
H=A**2 + B**2
H=math.sqrt(H)
print('La hipotenusa es:', H)