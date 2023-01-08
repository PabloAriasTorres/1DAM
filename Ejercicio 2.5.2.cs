/*) Crea un programa en el que el usuario deba adivinar un número del 1 al
100 (prefijado en el programa). En cada pasada deberá avisar de si se ha pasado o
se ha quedado corto.*/
using System;
class Ejercicio_252
{
	static void Main()
	{
		int num1, n=69;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		while(num1!=n)
		{
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
		}
	}
}
			
