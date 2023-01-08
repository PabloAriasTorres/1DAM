/*Crea una versión alternativa del ejercicio 2.2.11.1, que no utilice
"continue" sino el "if" contrario*/
using System;
class Ejercicio_22113
{
	static void Main()
	{
		for(int a=20; a>=10; a--)
		{
			if(a!=13)
			{
				Console.Write("{0} ",a);
			}
		}
	}
}
