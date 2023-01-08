/*) Crea un programa que escriba los números del 20 al 10, descendiendo,
excepto el 13, usando "continue".*/
using System;
class Ejercicio_22111
{
	static void Main()
	{
		for(int a=20; a>=10; a--)
		{
			if(a==13)
			{
				continue;
			}
			Console.Write("{0} ",a);
		}
	}
}
