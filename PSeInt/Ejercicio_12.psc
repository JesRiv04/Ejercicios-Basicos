Algoritmo Ejercicio_12
	Definir N, C, S Como Entero
	N <- 1
	C = 0
	S = 0
	Escribir 'Ingrese una nota:'
	Leer N
	Mientras N<>0 Hacer
		S <- S + N
		Escribir 'Ingrese una nota:'
		Leer N
		C <- C + 1
	FinMientras
	P <- S / C
	Escribir 'El promedio es:', P
FinAlgoritmo
