/*Crea un programa que muestre los números del 100 al 200 (ambos
incluidos) que sean divisibles entre 7 y a la vez entre 3.*/
using System;
class Ejercicio_2233
{
	static void Main()
	{
		int m, l;
		for(int n=100; n<=200;n++)
		{
			m=n%7;
			l=n%3;
			
			if((m==0)&&(l==0))
			{
				Console.WriteLine("{0}",n);
			}
		}
	}
}
