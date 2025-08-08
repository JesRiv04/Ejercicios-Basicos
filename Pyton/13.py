Total = 0.0
for i in range(1, 51):
    Horas = float(input("Ingrese las horas trabajadas: "))
    Salario = Horas * 100
    Total += Salario
print(f"El salario total es: ${Total}")
