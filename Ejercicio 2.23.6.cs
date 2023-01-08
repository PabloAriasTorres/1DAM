/*Crea un programa que muestre los números del 15 al 5, descendiendo
(pista: en cada pasada habrá que descontar 1, por ejemplo haciendo i=i-1, que se
puede abreviar i--).*/
using System;
class Ejercicio_2236
{
	static void Main()
	{
		for(int n=15; n>=5; n--)
		{
			Console.WriteLine("{0}",n);
		}
	}
}
