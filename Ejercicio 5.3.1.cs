/*Crea una función "DibujarCuadrado" que dibuje en pantalla un cuadrado de
asteriscos del ancho (y alto) que se indique como parámetro. Completa el
programa con un Main que permita probarla.*/
using System;
class Ejercicio_531
{
	static void DibujarCuadrado()
	{
		int alto=0, ancho=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el alto del cuadrado:");
				alto=Convert.ToInt32(Console.ReadLine());
				if(alto<1) throw new Exception("Error: la altura tiene que ser mayor que 1");
				Console.WriteLine("Introduce el ancho del cuadrado:");
				ancho=Convert.ToInt32(Console.ReadLine());
				if(ancho<1) throw new Exception("Error: el ancho tiene que ser mayor que 1");
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
			for( int i=0; i<alto; i++)
			{
				for( int j=0; j<ancho; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		while(ok==false);
	}
	
	static void Main()
	{
		DibujarCuadrado();
	}
}
