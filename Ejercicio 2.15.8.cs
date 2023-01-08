using System;
class Ejercicio_2158
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if((n1>0)&&(n2>0))
		{
			Console.WriteLine("Los dos son positivos");
		}
		else
		{
			Console.WriteLine("Al menos uno es positivo");
		}
		if((n1<0)&&(n2<0))
		{
			Console.WriteLine("Ninguno es positivo");
		}
	}
}
