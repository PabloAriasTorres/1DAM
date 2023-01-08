/*Crea una función "Inicial", que devuelva la primera letra de una cadena de
texto. Prueba esta función para calcular la primera letra de la frase "Hola".*/
using System;
class Ejercicio_544
{
	static char Inicial(string cadena)
	{
		char letra='a';
		
		letra=cadena[0];
		return(letra);
	}
	
	static void Main()
	{
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Inicial(cadena);
		Console.WriteLine("La primera letra es {0}",Inicial(cadena));
	}
}
