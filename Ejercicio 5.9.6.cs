/*Crea un programa que emplee recursividad para dar la vuelta a una cadena
de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH"). La función
recursiva se llamará "Invertir(cadena)". Como siempre, analiza cuál será el caso
base (qué longitud debería tener una cadena para que sea trivial darle la vuelta) y
cómo pasar del caso "n-1" al caso "n" (por ejemplo, si ya has invertido las 5
primeras letras, que ocurriría con la letra de la sexta posición).*/
using System;
class Ejercicio_596
{
	static string Invertir(string cadena)
	{
		if(cadena.Length <=1) return cadena;
		return Invertir(cadena.Substring(1))+cadena[0];
	}
	
	static void Main()
	{
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Console.WriteLine("La cadena invertida es {0}",Invertir(cadena));
	}
}
