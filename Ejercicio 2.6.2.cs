/*Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso,
pero aun así le preguntará su año de nacimiento.*/
using System;
class Ejercicio_262
{
	static void Main()
	{
		int edad, año;
		try
		{
			Console.WriteLine("Introduce tu edad:");
			edad=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Introduce tu año de nacimiento:");
			año=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Tienes {0} años",edad);
			Console.WriteLine("Naciste en {0}",año);
		}
		catch(FormatException)
		{
			Console.WriteLine("No es un número válido");
			Console.WriteLine("Introduce tu año de nacimiento:");
			año=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Naciste en {0}",año);
		}
	}
}
