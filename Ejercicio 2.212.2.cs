/*Crea un programa que escriba los números pares del 20 al 10,
descendiendo, excepto el 14, primero con "for" y luego con "while".*/
using System;
class Ejercicio_22122
{
	static void Main()
	{
		int j=20;
		for(int i=20; i>=10; i-=2)
		{
			if(i==14)
			{
				continue;
			}
			Console.Write("{0} ",i);
		}
		Console.WriteLine();
		while(j>=10)
		{
			if(j!=14)
			{
				Console.Write("{0} ",j);
			}
			j-=2;
		}
	}
}
			
