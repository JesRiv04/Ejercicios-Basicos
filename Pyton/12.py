N = 1
C = 0
S = 0
N = int(input('Ingrese una nota (0 para terminar): '))
while N != 0:
    S += N 
    C += 1 
    N = int(input('Ingrese una nota (0 para terminar): ')) 
if C > 0:
    P = S / C
    print('El promedio es:', P)
else:
    print('No se ingresaron notas.')
