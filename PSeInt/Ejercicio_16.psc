Algoritmo Ejercicio_16
	Definir BC, BV, BD, BC2, BM, C, Resto, N Como Entero
	BC <- 0
	BV <- 0
	BD <- 0
	BC2 <- 0
	BM <- 0
	Leer N
	C <- N
	Mientras N>=50000 Hacer
		BC <- BC+1
		C <- C-50000
		Leer C
	FinMientras
	Mientras N>=20000 Hacer
		BV <- BV+1
		C <- C-20000
		Leer C
	FinMientras
	Mientras N>=10000 Hacer
		BD <- BD+1
		C <- C-10000
		Leer C
	FinMientras
	Mientras N>=5000 Hacer
		BC2 <- BC2+1
		C <- C-5000
		Leer C
	FinMientras
	Mientras N>=1000 Hacer
		BM <- BM+1
		C <- C-1000
		Leer C
	FinMientras
	Resto <- C
	Escribir N," " BC," " BV," " BD," " BC2," " BM," " Resto
FinAlgoritmo
