/*Crea una función "Iniciales", similar a la del ejercicio 5.7.2.2, que reciba
una cadena como "Nacho Cabanes" y devuelva las letras N y C (primera letra, y
letra situada tras el primer espacio), pero esta vez usando parámetros de salida.
Crea un "Main" que te permita comprobar que funciona correctamente.*/
using System;
class Ejercicio_5731
{
	static void Iniciales(string cadena, out char[] ini)
	{
		string[] palabras = cadena.Split(' ');
		ini = new char[palabras.Length];
		
		for(int i=0; i<palabras.Length; i++)
		{
			//~ ini[0]=cadena[0];
			//~ if(cadena[i]==' ')
			//~ {
				//~ ini[i]=cadena[i+1];
			//~ }
			ini[i] = palabras[i][0];
		}
	}
	
	static void Main()
	{
		char[] ini;
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Iniciales(cadena, out ini);
		for(int i=0; i<ini.Length;i++)
		{
			Console.WriteLine("{0} ",ini[i]);
		}
	}
}
