using System;
class Ejercicios_411
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 4.1.1.1");
			Console.WriteLine("Escribe 2 para el ejercicio 4.1.1.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_4111(); break;
				case 2: Ejercicio_4112(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario 4 números, los memorice (utilizando un
array), calcule su media aritmética y después muestre en pantalla la media y los
datos tecleados.*/
	static void Ejercicio_4111()
	{
		int[] numeros= new int[4];
		int media, suma=0;
		for(int i=0; i<4; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
					
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			suma=suma+numeros[i];
		}
		media=suma/4;
		Console.WriteLine("La media es {0}",media);
	}
	/*) Un programa que pida al usuario 5 números reales (pista: necesitarás un
array de "float") y luego los muestre en el orden contrario al que se introdujeron.*/
	static void Ejercicio_4112()
	{
		int[] numeros= new int[5];
		
		for(int i=0; i<5; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		Console.WriteLine("{0} {1} {2} {3} {4}",numeros[4],numeros[3],numeros[2],numeros[1],numeros[0]);
	}
}
