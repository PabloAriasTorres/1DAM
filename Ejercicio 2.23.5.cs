/*Crea un programa que muestre los primeros ocho números pares: 2 4 6 8
10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar
el doble del valor que hace de contador).*/
using System;
class Ejercicio_2235
{
	static void Main()
	{
		for(int n=2; n<=16; n+=2)
		{
			Console.WriteLine("{0}",n);
		}
	}
}

