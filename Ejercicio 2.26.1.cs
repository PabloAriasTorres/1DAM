/* Crea un programa que escriba 4 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 5.*/
using System;
class Ejercicio_2261
{
	static void Main()
	{
		int fila, columna, alto=4, ancho=5;
		
		for(fila=1; fila<=alto; fila++)
		{
			for(columna=1; columna<=ancho; columna++)
			{
				Console.Write("{0}",columna);
			}
			Console.WriteLine();
		}
	}
}
