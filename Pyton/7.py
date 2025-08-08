import math
N=int(input('Ingrese la calificaion:'))
if N>0 & N<21:
    if N>18 & N<21:
        print('La Nota es A')
    else:
        if N>15 & N<19:
            print('La nota es B')
        else:  
            if N>12 & N<16:
                print('La nota es C')
            else: 
                if N>9 & N<13:
                    print('La nota es D')
                else:    
                    if N>0 & N<10:
                        print('La nota es E')
                    else:    
                        print('La nota es invalida')
else:
    print('Calificacion Invalida')