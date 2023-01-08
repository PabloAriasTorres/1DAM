/*Crea un programa que "dibuje" un triángulo creciente, alineado a la
derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice que
desea 4 caracteres de alto, el triángulo sería así:*/
using System;
class Ejercicio_258
{
	static void Main()
	{
		int alto;
		Console.WriteLine("Introduce la altura:");
		alto=Convert.ToInt32(Console.ReadLine());
		for(int i=1; i<=alto; i++)
		{
			for(int h=1; h<=alto-i; h++)
			{
				Console.Write(" ");
			}
			for(int j=1; j<=i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
