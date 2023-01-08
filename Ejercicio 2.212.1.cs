/*Crea un programa que escriba los números del 100 al 200, separados
por un espacio, sin avanzar de línea, usando "for". En la siguiente línea, vuelve a
escribirlos usando "while".*/
using System;
class Ejercicio_22121
{
	static void Main()
	{
		int i=100;
		for( int j=100; j<=200; j++)
		{
			Console.Write("{0} ",j);
		}
		Console.WriteLine();
		while(i<=200)
		{
			Console.Write("{0} ",i);
			i++;
		}
	}
}
