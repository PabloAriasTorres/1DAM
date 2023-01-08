/*Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando
25 líneas en blanco. Crea también un "Main" que permita probarla.*/
using System;
class Ejercicio_521
{
	static void BorrarPantalla()
	{
		for( int i=0; i<25; i++)
		{
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		BorrarPantalla();
		Console.WriteLine("Borramos");
	}
}
