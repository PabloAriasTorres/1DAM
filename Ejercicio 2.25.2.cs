/*Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "while": 12345123451234512345.*/
using System;
class Ejercicio_2252
{
	static void Main()
	{
		int n=1, m=1;
		while(n<=4)
		{
			while(m<=5)
			{
				Console.Write("{0}",m);
				m++;
			}
		n++;	
		}
	}
}
