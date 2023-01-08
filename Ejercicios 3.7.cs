/*Crea un programa que pida al usuario una cantidad de kilómetros y
muestre su equivalencia en millas. El valor de conversión debe estar en una
variable definida con "var".*/
using System;
class Ejercicio_371
{
	static void Main()
	{
		float km=0;
		Console.WriteLine("Introduce una cantidad de km:");
		km=float.Parse(Console.ReadLine());
		var millas=1.609;
		var total=km/millas;
		Console.WriteLine("{0}",total);
	}
}
		
