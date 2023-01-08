using System;
class Ejercicio_22112
{
	static void Main()
	{
		int n, cuadrado;
		Console.WriteLine("Introduce un número (0 para salir):");
		n=Convert.ToInt32(Console.ReadLine());
		while(n!=0)
		{
			cuadrado=n*n;
			Console.WriteLine("{0}",cuadrado);
			Console.WriteLine("Introduce un número (0 para salir):");
			n=Convert.ToInt32(Console.ReadLine());
			if(n==0)
			{
				Console.WriteLine("Salir");
			}
		}
	}
}
			
