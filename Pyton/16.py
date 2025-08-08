BC = 0  
BV = 0  
BD = 0  
BC2 = 0  
BM = 0  

N = int(input("Ingrese la cantidad: "))
C = N

while C >= 50000:
    BC += 1
    C -= 50000

while C >= 20000:
    BV += 1
    C -= 20000

while C >= 10000:
    BD += 1
    C -= 10000

while C >= 5000:
    BC2 += 1
    C -= 5000

while C >= 1000:
    BM += 1
    C -= 1000

Resto = C

print(f"{N} -> {BC} billetes de 50000, {BV} billetes de 20000, {BD} billetes de 10000, {BC2} billetes de 5000, {BM} billetes de 1000, resto: {Resto}")
