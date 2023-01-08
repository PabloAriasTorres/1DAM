/*Crea un programa que escriba en pantalla los números pares del 26 al 10
(descendiendo), usando "do..while".*/
using System;
class Ejercicio_2223
{
	static void Main()
	{
		int n=28;
		do
		{
			n=n-2;
			Console.WriteLine("{0}",n);
		}
		while(n>10);
		{
		}
	}
}
