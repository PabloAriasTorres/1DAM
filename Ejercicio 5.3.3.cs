/*Crea una función "DibujarRectanguloHueco" que dibuje en pantalla un
rectángulo hueco del ancho y alto que se indiquen como parámetros, formado por
una letra que también se indique como parámetro. Completa el programa con un
Main que pida esos datos al usuario y dibuje el rectángulo.*/
using System;
class Ejercicio_533
{
	static void DibujarRectanguloHueco(int alto, int ancho, char letra)
	{
		for( int i=1; i<=alto; i++)
		{
			for( int j=1; j<=ancho; j++)
			{
				if(i==1 || j==1 || i==alto || j==ancho) Console.Write("{0}",letra);
				else Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		int alto=0, ancho=0;
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el alto del rectángulo:");
				alto=Convert.ToInt32(Console.ReadLine());
				if(alto<1) throw new Exception("Error: la altura tiene que ser mayor que 1");
				Console.WriteLine("Introduce el ancho del rectángulo:");
				ancho=Convert.ToInt32(Console.ReadLine());
				if(ancho<1) throw new Exception("Error: el ancho tiene que ser mayor que 1");
				Console.WriteLine("Introduce una letra como parámetro:");
				letra=Convert.ToChar(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		DibujarRectanguloHueco(alto, ancho, letra);
	}
}
