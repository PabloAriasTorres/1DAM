/*Crea una nueva versión de la función "DibujarRectangulo", que se apoye en
la "EscribirRepetido" que acabas de crear.*/
using System;
class Ejercicio_535
{
	static void DibujarRectangulo(int num)
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
			
			
			for(int k=0; k<num; k++)
			{
				for( int i=0; i<alto; i++)
				{
					for( int j=0; j<ancho; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
				Console.WriteLine();
			}
		}
		while(ok==false);
	}
	
	static int EscribirRepetido()
	{
		int num=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número para repitir el rectángulo:");
				num=Convert.ToInt32(Console.ReadLine());
				if(num<1) throw new Exception("Error: el número tiene que ser mayor que 1");
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
		return(num);
	}
	
	static void Main()
	{
		DibujarRectangulo(EscribirRepetido());
	}
}
