using System;
class Ejercicio_21510
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if(n1==n2)
		{
			Console.WriteLine("Son iguales");
		}
		else
		{
			if(n1>n2)
			{
				Console.WriteLine("{0} es el mayor",n1);
			}
			else
			{
				Console.WriteLine("{0} es el mayor",n2);
			}
		}
	}
}
