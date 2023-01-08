/*Crea un programa que cuente cuantas veces aparece la letra 'a' en una
frase que teclee el usuario, utilizando "foreach".*/
using System;
class Ejercicio_241
{
	static void Main()
	{
		int contador=0;
		Console.WriteLine("Dime tu nombre");
		string nombre=Console.ReadLine();
		foreach(char letra in nombre)
		{
			Console.Write(letra);
			if((letra=='a') || (letra=='A'))
			{
				contador=contador+1;
			}
		}
		Console.WriteLine(" tiene {0} a o A",contador);
	}
}
