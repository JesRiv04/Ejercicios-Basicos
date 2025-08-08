Algoritmo Ejercicio_15
	Definir T, ANOS, Meses, Semanas, Dias Como Entero
	Escribir 'Ingrese el numero de dias:'
	Leer T
	Si T>=365 Entonces
		Mientras T>=365 Hacer
			T <- T-365
			ANOS <- ANOS+1
		FinMientras
	FinSi
	Si T>=30 Entonces
		Mientras T>=30 Hacer
			T <- T-30
			Meses <- Meses+1
		FinMientras
	FinSi
	Si T>=7 Entonces
		Mientras T>=7 Hacer
			T <- T-7
			Semanas <- Semanas+1
		FinMientras
	FinSi
	Dias <- T
	Escribir 'El tiempo es Años:', ANOS, 'Meses:', Meses, 'Semanas:', Semanas, 'Dias:', Dias
FinAlgoritmo
