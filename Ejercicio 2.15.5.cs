using System;
class Ejercicio_2155
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if(n1%2==0)
		{
			Console.WriteLine("{0} es par",n1);
		}
		else
		{
			Console.WriteLine("{0} no es par",n1);
		}
		if(n2%2==0)
		{
			Console.WriteLine("{0} es par",n2);
		}
		else
		{
			Console.WriteLine("{0} no es par",n2);
		}
	}
}
		
