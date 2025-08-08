T = int(input('Ingrese el número de días: '))
ANOS = 0
Meses = 0
Semanas = 0
Dias = 0

if T >= 365:
    while T >= 365:
        T -= 365
        ANOS += 1

if T >= 30:
    while T >= 30:
        T -= 30
        Meses += 1

if T >= 7:
    while T >= 7:
        T -= 7
        Semanas += 1

Dias = T

print(f'El tiempo es {ANOS} Años, {Meses} Meses, {Semanas} Semanas, {Dias} Días')
