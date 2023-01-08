/*Crea un triángulo de asteriscos, que mostrará uno en la primera fila, dos
en la segunda, tres en la tercera y así sucesivamente, hasta llegar al tamaño
indicado por el usuario.*/
using System;
class Ejercicio_2264
{
	static void Main()
	{
		int i, j, tamaño;
		Console.WriteLine("Introduce el tamaño del triángulo:");
		tamaño=Convert.ToInt32(Console.ReadLine());
		for(i=1; i<=tamaño; i++)
		{
			for(j=1;j<=i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
