using System;
class Ejercicio_Triángulo
{
	static void Main()
	{
		int tamaño;
		try
		{
			Console.WriteLine("Introduce el tamaño del triángulo:");
			tamaño=Convert.ToInt32(Console.ReadLine());
		
			for(int i=1; i<=tamaño; i++)
			{
				for(int h=1; h<=tamaño-i; h++)
				{
					Console.Write(" ");
				}
				for(int j=1; j<=i; j++)
				{
					Console.Write("*");
				}
				for(int k=1; k<=i-1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		catch(FormatException)
		{
			Console.WriteLine("No es número válido");
		}
	}
}
