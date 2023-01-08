using System;
class Ejercicios_47
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.7.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.7.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.7.3");
				Console.WriteLine("Escribe 6 para el ejercicio 4.7.6");
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
				case 1: Ejercicio_471(); break;
				case 2: Ejercicio_472(); break;
				case 3: Ejercicio_473(); break;
				case 6: Ejercicio_476(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario 6 números en coma flotante y los muestre
ordenados de menor a mayor. Escoge el método de ordenación que prefieras.*/
	static void Ejercicio_471()
	{
		int[] numeros = new int[6];
		int datoTemporal;
		
		for(int i=0; i<numeros.Length; i++)
		{
			Console.WriteLine("Introduce un número:");
			numeros[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0; i<numeros.Length;i++)
		{
			for( int j=i+1; j<numeros.Length;j++)
			{
				if(numeros[i]>numeros[j])
				{
					datoTemporal=numeros[i];
					numeros[i]=numeros[j];
					numeros[j]=datoTemporal;
				}
			}
		}
		Console.Write("Los datos ordenados de menor a mayor son: ");
		for(int i=0;i<numeros.Length;i++)
		{
			Console.Write("{0} ",numeros[i]);
		}
	}
	/*Un programa que pida al usuario 5 nombres y los muestre ordenados
alfabéticamente (recuerda que para comparar cadenas no podrás usar el símbolo
">", sino "CompareTo").*/
	static void Ejercicio_472()
	{
		string[] nombres = new string[5];
		string datoTemporal;
		
		for( int i=0; i<nombres.Length;i++)
		{
			Console.WriteLine("Introduce un nombre:");
			nombres[i]=Console.ReadLine();
		}
		for( int i=0; i<nombres.Length;i++)
		{
			for( int j=i+1; j<nombres.Length;j++)
			{
				if(nombres[i].CompareTo(nombres[j])>0)
				{
					datoTemporal=nombres[i];
					nombres[i]=nombres[j];
					nombres[j]=datoTemporal;
				}
			}
		}
		Console.Write("Los nombres ordenados alfabéticamente son: ");
		for( int i=0;i<nombres.Length;i++)
		{
			Console.Write("{0} ",nombres[i]);
		}
	}
	/* Un programa que pida al usuario varios números, los vaya añadiendo a un
array, mantenga el array ordenado continuamente y muestre el contenido tras
añadir cada nuevo dato (todos los datos se mostrarán en la misma línea,
separados por espacios en blanco). Terminará cuando el usuario teclee "fin" en vez
de un numero.*/
	static void Ejercicio_473()
	{
		int tamanyo=10, datoTemporal;
		int[] numeros = new int[tamanyo];
		
		for(int i=0; i<numeros.Length;i++)
		{
			Console.WriteLine("Introduce un número:");
			numeros[i]=Convert.ToInt32(Console.ReadLine());
			tamanyo++;
			if(numeros[i]==69) break;
			for(int k=0; k<numeros.Length;k++)
			{	
				for( int j=k+1; j<numeros.Length;j++)
				{
					if(numeros[k]>numeros[j])
					{
						datoTemporal=numeros[k];
						numeros[k]=numeros[j];
						numeros[j]=datoTemporal;
					}
				}
			}
		}
		for( int i=0;i<numeros.Length;i++)
		{
			Console.Write("{0} ",numeros[i]);
		}
	}
	/*Crea una variante del ejercicio 4.7.3, pero usando esta vez Array.Sort para
ordenar: un programa que pida al usuario varios números, los vaya añadiendo a
un array, mantenga el array ordenado continuamente y muestre el resultado tras
añadir cada nuevo dato (todos los datos se mostrarán en la misma línea,
separados por espacios en blanco). Terminará cuando el usuario teclee "fin".*/
	static void Ejercicio_476()
	{
		int tamanyo=10;
		int[] numeros = new int[tamanyo];
		
		for(int i=0; i<numeros.Length; i++)
		{
			Console.WriteLine("Introduce un número:");
			numeros[i]=Convert.ToInt32(Console.ReadLine());
			if(numeros[i]!=69)
			{
				tamanyo++;
				Array.Sort(numeros);
				foreach(int numero in numeros)
				{
					Console.Write("{0}",numero);
				}
			}
			Console.WriteLine();
			if(numeros[i]==69) break;
		}
	}
}
