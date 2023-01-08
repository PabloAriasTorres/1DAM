using System;
class Ejercicio_2112
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if(n1>n2)
		{
			Console.WriteLine("{0} es mayor que {1}",n1,n2);
		}
		if(n2>n1)
		{
			Console.WriteLine("{0} es mayor que {1}",n2,n1);
		}
	}
}
