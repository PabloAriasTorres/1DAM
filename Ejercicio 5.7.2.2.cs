/*Crea una función "Iniciales", que reciba una cadena como "Nacho
Cabanes" y devuelva las letras N y C (primera letra, y letra situada tras el primer
espacio), usando parámetros por referencia. Crea un "Main" que te permita
comprobar que funciona correctamente.*/
using System;
class Ejercicio_5722
{
	static void Iniciales(ref string cadena, ref char[] ini)
	{
		for(int i=0; i<cadena.Length; i++)
		{
			ini[0]=cadena[0];
			if(cadena[i]==' ')
			{
				ini[i]=cadena[i+1];
			}
		}
	}
	
	static void Main()
	{
		char[] ini = new char[50];
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Iniciales(ref cadena,ref ini);
		for(int i=0; i<ini.Length;i++)
		{
			Console.WriteLine("{0}",ini[i]);
		}
	}
}
