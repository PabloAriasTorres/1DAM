/*Haz un programa que dibuje un cuadrado de asteriscos, cuyo ancho (y
alto, que tendrá el mismo valor) será introducido por el usuario.*/
using System;
class Ejercicio_2263
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
