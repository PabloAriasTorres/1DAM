/*Crea una versión alternativa del ejercicio 2.2.11.2, que no emplee
"continue" sino el "if" contrario.*/
using System;
class Ejercicio_22114
{
	static void Main()
	{
		int multiplo;
		for(int a=2; a<=106; a+=2)
		{
			multiplo=a%10;
			if(multiplo!=0)
			{
				Console.Write("{0} ",a);
			}
		}
	}
}
