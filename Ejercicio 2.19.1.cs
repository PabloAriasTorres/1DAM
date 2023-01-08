/*Crea un programa que pida un número del 1 al 10 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
programa escribirá "uno").*/
using System;
class Ejercicio_2191
{
	static void Main()
	{
		int n;
		Console.WriteLine("Introduce un número del 1 al 10:");
		n=Convert.ToInt32(Console.ReadLine());
		switch(n)
		{
			case 1: Console.WriteLine("Uno"); break;
			case 2: Console.WriteLine("Dos"); break;
			case 3: Console.WriteLine("Tres"); break;
			case 4: Console.WriteLine("Cuatro"); break;
			case 5: Console.WriteLine("Cinco"); break;
			case 6: Console.WriteLine("Seis"); break;
			case 7: Console.WriteLine("Siete"); break;
			case 8: Console.WriteLine("Ocho"); break;
			case 9: Console.WriteLine("Nueve"); break;
			case 10: Console.WriteLine("Diez"); break;
			default: Console.WriteLine("No es del uno al diez"); break;
		}
	}
}
			
