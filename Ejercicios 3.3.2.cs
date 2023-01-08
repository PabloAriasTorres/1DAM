/*Crea un programa que pida al usuario que teclee cuatro letras y las
muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles. Por
ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola".*/
using System;
class Ejercicio_332
{
	static void Main()
	{
		char letra1='a', letra2='a', letra3='a', letra4='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la primera letra:");
				letra1=Convert.ToChar(Console.ReadLine());
				if(letra1>='0' && letra1<='9') throw new Exception("tienes que introducir una letra");
				Console.WriteLine("Introduce la segunda letra:");
				letra2=Convert.ToChar(Console.ReadLine());
				if(letra2>='0' && letra2<='9') throw new Exception("tienes que introducir una letra");
				Console.WriteLine("Introduce la tercera letra:");
				letra3=Convert.ToChar(Console.ReadLine());
				if(letra3>='0' && letra3<='9') throw new Exception("tienes que introducir una letra");
				Console.WriteLine("Introduce la cuarta letra:");
				letra4=Convert.ToChar(Console.ReadLine());
				if(letra4>='0' && letra4<='9') throw new Exception("tienes que introducir una letra");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("Error: {0}",e.Message);
			}
		}
		while(ok==false);
		Console.WriteLine("\"{0}{1}{2}{3}\"",letra4,letra3,letra2,letra1);
	}
}
