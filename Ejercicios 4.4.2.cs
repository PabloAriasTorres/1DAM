/*Crea un programa que pregunte al usuario su nombre y le responda cuál
es su inicial.*/
using System;
class Ejercicio_4421
{
	static void Main()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		Console.WriteLine("Tu inicial es {0}",nombre[0]);
	}
}
