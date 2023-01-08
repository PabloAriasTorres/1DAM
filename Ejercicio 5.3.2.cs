/*Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo
del ancho y alto que se indiquen como parámetros, en ese orden. Incluye un Main
para probarla.*/
using System;
class Ejercicio_532
{
	static void DibujarRectangulo()
	{
		int alto=0, ancho=0;
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
		DibujarRectangulo();
	}
}
