A=int(input('Ingrese el primer numero:'))
B=int(input('Ingrese el segundo numero:'))
C=int(input('Ingrese el tercer numero:'))
if A==B:
   print('A y B son iguales')
else: 
    if A==C:
        print('A y C son iguales')
    else:
        if B==C:
          print('B y C son iguales')
        else:
           if A>B:
              if(A>C):
                 print('El mayor es A')
              else:
                   print('El mayor es C')
           else: 
               if B>C:
                    print('El mayor es B')
               else:
                     print('El mayor es C')