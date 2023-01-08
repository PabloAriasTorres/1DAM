/*) Dibuja un triángulo de asteriscos descendente. Por ejemplo, si el usuario
escoge "4" como tamaño, la primera fila tendrá 4 asteriscos, la segunda tendrá 3,
la siguiente tendrá 2 y la última tendrá 1.*/
using System;
class Ejercicio_2265
{
	static void Main()
	{
		int i, j, tamaño;
		Console.WriteLine("Introduce el tamaño del triángulo:");
		tamaño=Convert.ToInt32(Console.ReadLine());
		for(i=tamaño; i>=1; i--)
		{
			for(j=1;j<=i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
