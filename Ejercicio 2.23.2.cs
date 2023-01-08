/*Crea un programa que escriba en pantalla los números del 1 al 50 que
sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto
de la división entre 3 resulta 0).*/
using System;
class Ejercicio_2232
{
	static void Main()
	{
		int m;
		for(int n=1; n<51;n++)
		{
			m=n%3;
			if(m==0)
			{
				Console.WriteLine("{0}",n);
			}
		}
	}
}
