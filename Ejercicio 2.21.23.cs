using System;
class Ejercicio_22123
{
	static void Main()
	{
		int n, i=1;
		Console.WriteLine("Introduce un número:");
		n=Convert.ToInt32(Console.ReadLine());
		if(n<=9)
		{
			Console.WriteLine("El número tiene una cifra");
		}
		else
		{
			while(n>=10)
			{
				n=n/10;
				i=i+1;
			}
		}
		Console.WriteLine("El número tiene {0} cifras",i);
	}
}
