/*Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "for": 12345123451234512345.*/
using System;
class Ejercicio_2251
{
	static void Main()
	{
		for(int n=1; n<=4; n++)
		{
			for(int m=1; m<=5; m++)
			{
				Console.Write("{0}",m);
			}
		}
	}
}
