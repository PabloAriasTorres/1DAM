/*Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
****
****
*****/
using System;
class Ejercicio_2262
{
	static void Main()
	{
		int alto, ancho, fila, columna;
		Console.WriteLine("Introduce el alto:");
		alto=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el ancho:");
		ancho=Convert.ToInt32(Console.ReadLine());
		for(fila=1; fila<=alto; fila++)
		{
			for(columna=1; columna<=ancho; columna++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
		
