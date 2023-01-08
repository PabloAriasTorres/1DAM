/*Haz un programa que dé al usuario la oportunidad de adivinar un número
del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada
pasada deberá avisar de si se ha pasado o se ha quedado corto.*/
using System;
class Ejercicio_253
{
	static void Main()
	{
		int num1, n=69, i=6;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
			if(i!=0)
			{
				while(num1!=n)
				{
					Console.WriteLine("Te quedan {0} intentos",i);
					i--;
					if(num1>n)
					{
						Console.WriteLine("Te has pasado");
						Console.WriteLine("Introduce un número:");
						num1=Convert.ToInt32(Console.ReadLine());
					}
					if(num1<n)
					{
						Console.WriteLine("Te has quedado corto");
						Console.WriteLine("Introduce un número:");
						num1=Convert.ToInt32(Console.ReadLine());
					}
					if(num1==n)
					{
					Console.WriteLine("Has acertado");
					}
					if(i==0)
					{
						Console.WriteLine("Has perdido");
						break;
					}
					
				}
			}
	}
}
