/*Crea una función "DibujarTriángulo" que reciba una letra y un número, y
escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la
que se ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir*/
using System;
class Ejercicio_556
{
	static void DibujarTriangulo(int ancho, char letra)
	{
		for( int i=0; i<ancho; i++)
		{
			for(int j=0;j<ancho-i;j++)
			{
				Console.Write("{0}",letra);
			}
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		int ancho=0;
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el ancho del triángulo:");
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
		DibujarTriangulo(ancho, letra);
	}
}
