using System;
class Ejercicios_445
{
	static void Main()
	{
		int n=0;
		bool entrar=false;
		
		do
		{
			try
			{
				Console.WriteLine("Escribe 0 para salir");
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.5.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.5.2");
				Console.WriteLine();
				Console.WriteLine("Introduce el número del ejercicio:");
				n=Convert.ToInt32(Console.ReadLine());
				entrar=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
				Console.WriteLine();
			}
		
			switch(n)
			{
				case 0: break;
				case 1: Ejercicio_4451(); break;
				case 2: Ejercicio_4452(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario 10 frases, las guarde en un array, y
luego le pregunte textos de forma repetitiva, e indique si cada uno de esos textos
aparece como parte de alguno de los elementos del array. Terminará cuando el
texto introducido sea "fin".*/
	static void Ejercicio_4451()
	{
		string[] frases= new string[10];
		string texto="a";
		bool encontrado=false;
		
		for( int i=0;i<frases.Length; i++)
		{
			Console.WriteLine("Introduce una frase:");
			frases[i]=Console.ReadLine();
		}
		Console.WriteLine();
		while(true)
		{
			Console.WriteLine("Introduce algún texto( fin para acabar)");
			texto=Console.ReadLine();
			if(texto=="fin") break;
			for( int i=0; i<frases.Length;i++)
			{
				if(frases[i].IndexOf(texto)>=0)
				{
					Console.WriteLine("{0} aparece dentro de {1}",texto,frases[i]);
					encontrado=true;
				}
			}
			if(encontrado==false) Console.WriteLine("{0} no ha aparecido",texto);
		}
	}
	/*Crea una versión del ejercicio 4.4.5.1 en la que, en caso de que alguno de
los textos aparezca como subcadena, se informe además de si se encuentra
exactamente al principio.*/
	static void Ejercicio_4452()
	{
		string[] frases= new string[10];
		string texto="a";
		
		for( int i=0;i<frases.Length; i++)
		{
			Console.WriteLine("Introduce una frase:");
			frases[i]=Console.ReadLine();
		}
		Console.WriteLine();
		for( int i=0; i<frases.Length;i++)
		{
			Console.WriteLine("Introduce algún texto( fin para acabar)");
			texto=Console.ReadLine();
			if(texto=="fin") break;
			if(frases[i].IndexOf(texto)>=0)
			{
				Console.WriteLine("{0} aparece dentro de {1} en la posición {2}",texto,frases[i],frases[i].IndexOf(texto));
			}
			else
			{
				Console.WriteLine("No ha aparecido");
			}
		}
	}
}
