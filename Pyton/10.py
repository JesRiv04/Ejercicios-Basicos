M=0
E=int(input('Ingrese la hora de entrada:'))
S=int(input('Ingrese la hora de salida:'))
T=S-E
if isinstance(T, int):
   T=T+1
if T==1: 
    M=15
else:
    M=15+(T-1)*10
print('El monto a pagar es:')
print(M)  