/*Crea un programa que muestre una cuenta atrás (3 2 1 0) desde el número
que introduzca el usuario hasta cero. Ese número debe estar entre 1 y 10 (y el
programa debe comprobar que realmente lo está, y volverlo a pedir tantas veces
como sea necesario, en caso de que no sea así).*/
using System;
class Ejercicio_251
{
	static void Main()
	{
		int num1;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		while((num1<1)||(num1>10))
		{
			Console.WriteLine("Error: Vuelve a introducir un número");
			Console.WriteLine("Introduce un número:");
			num1=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=num1; i>=0; i--)
		{
			Console.Write("{0} ",i);
		}
	}
}
			
