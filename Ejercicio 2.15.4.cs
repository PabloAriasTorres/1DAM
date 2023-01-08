using System;
class Ejercicio_2154
{
	static void Main()
	{
		int n1;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		if(n1%2==0)
		{
			Console.WriteLine("{0} es múltiplo de 2",n1);
		}
		else
		{
			Console.WriteLine("{0} no es múltiplo de 2",n1);
		}
		if(n1%3==0)
		{
			Console.WriteLine("{0} es múltiplo de 3",n1);
		}
		else
		{
			Console.WriteLine("{0} no es múltiplo de 3",n1);
		}
	}
}
