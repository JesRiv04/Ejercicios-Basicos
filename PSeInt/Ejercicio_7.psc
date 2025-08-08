Algoritmo Ejercicio_7
	Definir N Como Entero
	Escribir 'Ingresa la Calificacion:'
	Leer N
	Si N>0 Y N<21 Entonces
		Si N>18 Y N<21 Entonces
			Escribir 'La nota es A'
		SiNo
			Si N>15 Y N<19 Entonces
				Escribir 'La nota es B'
			SiNo
				Si N>12 Y N<16 Entonces
					Escribir 'La nota es C'
				SiNo
					Si N>9 Y N<13 Entonces
						Escribir 'La nota es D'
					SiNo
						Si N>0 Y N<10 Entonces
							Escribir 'La nota es E'
						SiNo
							Escribir 'La nota es invalida'
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	SiNo
		Escribir 'Calificaion Invalida'
	FinSi
FinAlgoritmo
