/*Crea un programa que pida números positivos al usuario, y vaya
calculando y mostrando la suma de todos ellos (terminará cuando se teclea un
número negativo o cero).*/
using System;
class Ejercicio_2221
{
	static void Main()
	{
		int n, total=0;
		do
		{
			Console.WriteLine("Introduce un número(0 o negativo para acabar)");
			n=Convert.ToInt32(Console.ReadLine());
			if(n<=0)
			{
				Console.WriteLine("Salir");
			}
			else
			{
				total=total+n;
			}
		}
		while(n>0);
		{
			Console.WriteLine(" La suma de todos es {0}",total);
		}
	}
}
			
