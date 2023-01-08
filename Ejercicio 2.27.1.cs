/*Crea un programa que muestre las letras de la Z (mayúscula) a la A
(mayúscula, descendiendo).*/
using System;
class Ejercicio_2271
{
	static void Main()
	{
		for( char letra='Z'; letra>='A'; letra--)
		{
			Console.Write("{0} ",letra);
		}
	}
}
