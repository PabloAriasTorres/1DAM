using System;
class Ejercicio_2157
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if((n1%2==0)&&(n2%2==0))
		{
			Console.WriteLine("Al menos uno es par");
		}
		else
		{
			Console.WriteLine("Ninguno es par");
		}
	}
}
