/*Crea un programa que escriba 6 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 7. Debes usar dos variables llamadas
"linea" y "numero", y ambas deben estar declaradas en el "for".*/
using System;
class Ejercicio_2281
{
	static void Main()
	{
		int alto=6, ancho=7;
		for(int linea=1; linea<=alto; linea++)
		{
			for(int numero=1; numero<=ancho; numero++)
			{
				Console.Write("{0}",numero);
			}
			Console.WriteLine();
		}
	}
}
		
