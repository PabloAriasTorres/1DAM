using System;
class Ejercicios_331
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.3.1.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.3.1.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.3.1.3");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3311(); break;
				case 2: Ejercicio_3312(); break;
				case 3: Ejercicio_3313(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que pida una letra al usuario y diga si se trata de una
vocal.*/
	static void Ejercicio_3311()
	{
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una letra:");
				letra=Convert.ToChar(Console.ReadLine());
				if(letra>='0' && letra<='9') throw new Exception("tienes que introducir una letra");
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
		if(letra=='a' || letra=='e' || letra=='i' || letra=='o' || letra=='u' || letra=='A' || letra=='E' || letra=='I' || letra=='O' || letra=='U')
		{
			Console.WriteLine("{0} es una vocal",letra);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0} no es una vocal",letra);
			Console.WriteLine();
		}
	}
	/*Crea un programa que muestre letras alternas (una sí y una no) entre la
que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se
escribirá "aceg...".*/
	static void Ejercicio_3312()
	{
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una letra:");
				letra=Convert.ToChar(Console.ReadLine());
				if(letra>='0' && letra<='9') throw new Exception("tienes que introducir una letra");
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
		while(letra<='z')
		{
			Console.Write("{0} ",letra);
			letra++;
			letra++;
		}
		Console.WriteLine();
	}
	/* Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y una letra (por ejemplo, X) y escriba un rectángulo formado por
esa cantidad de letras:*/
	static void Ejercicio_3313()
	{
		int alto=0, ancho=0;
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una letra:");
				letra=Convert.ToChar(Console.ReadLine());
				if(letra>='0' && letra<='9') throw new Exception("tienes que introducir una letra");
				Console.WriteLine("Introduce el alto:");
				alto=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el ancho:");
				ancho=Convert.ToInt32(Console.ReadLine());
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
		for( int i=1; i<=alto; i++)
		{
			for( int j=1; j<=ancho; j++)
			{
				Console.Write("{0}",letra);
			}
			Console.WriteLine();
		}
	}
}
