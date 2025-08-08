G = 15
S = 20
R = 25
C = float(input("Cantidad de Gansitos: "))
P1 = G * C

C = float(input("Cantidad de Sabritas: "))
P2 = S * C

C = float(input("Cantidad de Refresco: "))
P3 = R * C

Total = P1 + P2 + P3

D = float(input("Cantidad recibida del cliente: "))

C2 = D - Total

print(f"El cambio es: ${C2}")
