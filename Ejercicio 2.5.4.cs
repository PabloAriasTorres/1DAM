/* Crea un programa que pida un número al usuario y diga si es primo
(divisible sólo entre 1 y él mismo).*/
using System;
class Ejercicio_254
{
	static void Main()
	{
		int num1, i=1, contador=0, dividir;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		while(i<=num1)
		{
			dividir=num1%i;
			if(dividir==0)
			{
				contador++;
			}
			i++;
		}	
		if(contador==2)
		{
			Console.WriteLine("{0} es primo",num1);
		}
		else
		{
			Console.WriteLine("{0} no es primo",num1);
		}
	}
}
	
