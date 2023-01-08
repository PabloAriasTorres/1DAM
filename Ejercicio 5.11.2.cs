/*Crea un segundo programa que use la función "DibujarRecuadro", en esta
ocasión llamando con los parámetros en orden inverso (primero el carácter, luego
el alto y finalmente el ancho).*/
using System;
class Ejercicio_5112
{
	static int DibujarRecuadro(char caracter, int alto, int ancho)
	{
		for(int i=0; i<alto; i++)
		{
			for(int j=0; j<ancho; j++)
			{
				Console.Write("{0}",caracter);
			}
			Console.WriteLine();
		}
		return alto;
	}
	
	static void Main()
	{
		int alto=0, ancho=0;
		char caracter='a';
		Console.WriteLine("Introduce el alto( 0 si no quieres introducirlo)");
		alto=Convert.ToInt32(Console.ReadLine());
		if(alto==0) alto=3;
		Console.WriteLine("Introduce el ancho:");
		ancho=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce un cáracter( / si no quieres introducirlo)");
		caracter=Convert.ToChar(Console.ReadLine());
		if(caracter=='/') caracter='*';
		Console.WriteLine(DibujarRecuadro(caracter,alto,ancho));
	}
}
