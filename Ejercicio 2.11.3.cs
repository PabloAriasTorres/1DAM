using System;
class Ejercicio_2113
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if(n1%n2==0)
		{
			Console.WriteLine("{0} es multiplo de {1}",n1,n2);
		}
	}
}
