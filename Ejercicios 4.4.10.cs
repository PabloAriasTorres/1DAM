/*Crea un programa que pida al usuario una frase y la muestre subrayada,
usando para ello una cadena formada por tantos guiones como letras tuviera la
frase inicial.*/
using System;
class Ejercicio_44101
{
	static void Main()
	{
		string frase="a";
		int contador=0;
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		Console.WriteLine();
		
		for( int i=0; i<frase.Length; i++)
		{
			contador++;
		}
		string guiones = new String('-',contador);
		Console.WriteLine("{0}",frase);
		Console.WriteLine("{0}",guiones);
	}
}
