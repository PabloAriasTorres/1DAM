using System;
class Ejercicios_326
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.6.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.6.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.2.6.3");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3261(); break;
				case 2: Ejercicio_3262(); break;
				case 3: Ejercicio_3263(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que pida números (en base 10) al usuario y muestre su
equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el
usuario introduzca el número 0.*/
	static void Ejercicio_3261()
	{
		int num1=1;
		bool ok=false;
		while(num1!=0)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					num1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			if(num1!=0)
			{
				Console.WriteLine(Convert.ToString(num1,16));
				Console.WriteLine(Convert.ToString(num1,2));
				Console.WriteLine();
			}
			else
			{
				break;
			}
		}
	}
	/*Crea un programa que pida al usuario la cantidad de rojo (por ejemplo,
255), verde (por ejemplo, 160) y azul (por ejemplo, 0) que tiene un color, y que
muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000).*/
	static void Ejercicio_3262()
	{
		int rojo=0, verde=0, azul=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la cantidad de rojo:");
				rojo=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la cantidad de verde:");
				verde=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la cantidad de azul:");
				azul=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		Console.Write(Convert.ToString(rojo,16));
		Console.Write(Convert.ToString(verde,16));
		Console.Write(Convert.ToString(azul,16));
		Console.WriteLine();
	}
	/*Crea un programa para mostrar los números del 0 a 255 en hexadecimal,
en 16 filas de 16 columnas cada una (la primera fila contendrá los números del 0 al
15 –decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente).*/
	static void Ejercicio_3263()
	{
		int num=0;
		while(num<=255)
		{
			for(int i=1; i<=16; i++)
			{
				for(int j=1; j<=16; j++)
				{
					Console.Write("{0}  ",num);
					num++;
				}
				Console.WriteLine();
			}
		}
	}
}
