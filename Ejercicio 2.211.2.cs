/*Crea un programa que escriba los números pares del 2 al 106, excepto
los que sean múltiplos de 10, usando "continue".*/
using System;
class Ejercicio_22112
{
	static void Main()
	{
		int multiplo;
		for(int a=2; a<=106; a+=2)
		{
			multiplo=a%10;
			if(multiplo==0)
			{
				continue;
			}
			Console.Write("{0} ",a);
		}
	}
}
