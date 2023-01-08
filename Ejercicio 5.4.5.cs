/* Crea una función "UltimaLetra", que devuelva la última letra de una cadena
de texto. Prueba esta función para calcular la última letra de la frase "Hola".*/
using System;
class Ejercicio_545
{
	static char UltimaLetra(string cadena)
	{
		char letra='a';
		
		letra=cadena[cadena.Length-1];
		return(letra);
	}
	
	static void Main()
	{
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		UltimaLetra(cadena);
		Console.WriteLine("La primera letra es {0}",UltimaLetra(cadena));
	}
}
