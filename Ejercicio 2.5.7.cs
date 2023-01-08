/*) Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una
fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco,
con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y
altura 3, el rectángulo sería así:*/
using System;
class Ejercicio_257
{
	static void Main()
	{
		int ancho, alto, i, j;
		Console.WriteLine("Introduce la altura:");
		alto=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el ancho:");
		ancho=Convert.ToInt32(Console.ReadLine());
		for( i=1; i<=alto; i++)
		{
			for( j=1; j<=ancho; j++)
			{
				if((i==1)||(j==1)||(i==alto)||(j==ancho))
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
}
		
