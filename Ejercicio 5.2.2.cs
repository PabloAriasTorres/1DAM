/*Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado
formato por 3 filas con 3 asteriscos cada una. Incluye un "Main" para probarla.*/
using System;
class Ejercicio_522
{
	static void DibujarCuadrado3x3()
	{
		for( int i=0; i<3; i++)
		{
			for( int j=0; j<3; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		DibujarCuadrado3x3();
	}
}
