/* Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas,
con el tamaño que indique el usuario, hasta un máximo de 9. Por ejemplo, si desea
tamaño 5, el cuadrado sería así:*/
using System;
class Ejercicio_2510
{
	static void Main()
	{
		int tamaño, h=1;
		Console.WriteLine("Introduce el tamaño del cuadrado:");
		tamaño=Convert.ToInt32(Console.ReadLine());
		if(tamaño>9)
		{
			Console.WriteLine("Error tamaño incorrecto");
		}
		else
		{
			for(int i=1; i<=tamaño; i++)
			{
				for(int j=1; j<=tamaño; j++)
				{
					Console.Write("{0}",h);
				}
				Console.WriteLine();
				h++;
			}
		}
	}
} 

