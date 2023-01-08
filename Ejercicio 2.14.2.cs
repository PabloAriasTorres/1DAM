using System;
class Ejercicio_2142
{
	static void Main()
	{
		int n1, n2, dividir;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		if(n2!=0)
		{
			dividir=n1/n2;
			Console.WriteLine("El resultado de dividir {0} entre {1} es {2}",n1,n2,dividir);
		}
		else
		{
			Console.WriteLine("Error: No se puede dividir entre cero");
		}
	}
}
