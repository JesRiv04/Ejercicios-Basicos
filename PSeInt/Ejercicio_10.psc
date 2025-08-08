Algoritmo Ejercicio_10
	Definir Entrada, Salida, Tiempo, Monto Como Real
	Escribir 'Ingrese la hora de entrada: '
	Leer Entrada
	Escribir 'Ingrese la hora de salida: '
	Leer Salida
	Tiempo <- Salida-Entrada
	Si Tiempo<>Trunc(Tiempo) Entonces
		Tiempo <- Trunc(horas_estadia)+1
	FinSi
	Si Tiempo=1 Entonces
		Monto <- 15
	SiNo
		Monto <- 15+(Tiempo-1)*10
	FinSi
	Escribir 'El monto a pagar es:$', Monto
FinAlgoritmo
