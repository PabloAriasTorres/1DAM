using System;
class Ejercicios_415
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 4.2.1");
			Console.WriteLine("Escribe 2 para el ejercicio 4.2.2");
			Console.WriteLine("Escribe 3 para el ejercicio 4.2.3");
			Console.WriteLine("Escribe 4 para el ejercicio 4.2.4");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_421(); break;
				case 2: Ejercicio_422(); break;
				case 3: Ejercicio_423(); break;
				case 4: Ejercicio_424(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario dos bloques de 10 números enteros
(usando un array de dos dimensiones). Después deberá mostrar el mayor dato
que se ha introducido en cada uno de ellos.*/
	static void Ejercicio_421()
	{
		int[][] numeros;
		int[] mayores= new int[2];
		numeros= new int[2][];
		numeros[0]= new int[10];
		numeros[1]= new int[10];
		
		for( int i=0; i<numeros.Length;i++)
		{
			for( int j=0; j<numeros[i].Length;j++)
			{
				Console.WriteLine("Introduce el número {0} para el bloque {1}:",j+1,i+1);
				numeros[i][j]=Convert.ToInt32(Console.ReadLine());
				if(j==0)
				{
					mayores[i]=numeros[i][j];
				}
				else if(numeros[i][j]>mayores[i])
				{
					mayores[i]=numeros[i][j];
				}
			}
		}
		Console.WriteLine("El mayor del primer bloque es {0} y el mayor del segundo bloque es {1}",mayores[0],mayores[1]);
		Console.WriteLine();
	}
	/*) Un programa que pida al usuario dos bloques de 6 cadenas de texto.
Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno
de los dos bloques de información anteriores. */
	static void Ejercicio_422()
	{
		string[][] cadenas;
		cadenas= new string[2][];
		cadenas[0]= new string[6];
		cadenas[1]= new string[6];
		string cadena="a";
		bool encontrado=false;
		
		for( int i=0; i<cadenas.Length; i++)
		{
			for( int j=0; j<cadenas[i].Length; j++)
			{
				Console.WriteLine("Introduce la cadena de texto {0} para el bloque {1}:",j+1,i+1);
				cadenas[i][j]=Console.ReadLine();
			}
		}
		Console.WriteLine();
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		for( int i=0; i<cadenas.Length;i++)
		{
			for( int j=0; j<cadenas[i].Length; j++)
			{
				if(cadena==cadenas[i][j])
				{
					encontrado=true;
				}
			}
		}
		if(encontrado==true)
		{
			Console.WriteLine("Si que aparece");
		}
		else
		{
			Console.WriteLine("No aparece");
		}
	}
	/* Un programa que pregunte al usuario el tamaño que tendrán dos bloques
de números enteros (por ejemplo, uno de 10 elementos y otro de 12). Luego
pedirá los datos para ambos bloques de datos. Finalmente deberá mostrar el
mayor dato que se ha introducido en cada uno de ellos.*/
	static void Ejercicio_423()
	{
		int bq1=0, bq2=0;
		int[] mayores= new int[2];
		int[][] numeros;
		numeros= new int[2][];
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la cantidad de números para el primer bloque:");
				bq1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la cantidad de números para el segundo bloque:");
				bq2=Convert.ToInt32(Console.ReadLine());
				if(bq1<=0 || bq2<=0) throw new Exception("Error: tiene que ser un número positivo y distinto de cero");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		while(ok==false);
		numeros[0]= new int[bq1];
		numeros[1]= new int[bq2];
		
		for( int i=0; i<numeros.Length; i++)
		{
			for(int j=0; j<numeros[i].Length; j++)
			{
				bool ok2=false;
				do
				{
					try
					{
						Console.WriteLine("Introduce el número {0} para el bloque {1}",j+1,i+1);
						numeros[i][j]=Convert.ToInt32(Console.ReadLine());
						ok2=true;
					}
					catch(FormatException)
					{
						Console.WriteLine("Error: no es un valor válido");
					}
				}
				while(ok2==false);
				if(j==0)
				{
					mayores[i]=numeros[i][j];
				}
				if(numeros[i][j]>mayores[i])
				{
					mayores[i]=numeros[i][j];
				}
			}
		}
		Console.WriteLine("El mayor del primer bloque es el {0} y el mayor del segundo bloque es el {1}",mayores[0],mayores[1]);
		Console.WriteLine();
	}
	/*Un programa que calcule el determinante de una matriz de 2x2.*/
	static void Ejercicio_424()
	{
		int[][] numeros;
		numeros= new int[2][];
		numeros[0]= new int[2];
		numeros[1]= new int[2];
		int determinante;
		
		for( int i=0; i<numeros.Length; i++)
		{
			for( int j=0; j<numeros[i].Length; j++)
			{
				bool ok=false;
				do
				{
					try
					{
						Console.WriteLine("Introduce el número {0} para el bloque {1}",j+1,i+1);
						numeros[i][j]=Convert.ToInt32(Console.ReadLine());
						ok=true;
					}
					catch(FormatException)
					{
						Console.WriteLine("Error: no es un valor válido");
					}
				}
				while(ok==false);
			}
		}
		determinante= (numeros[0][0]*numeros[1][1])-(numeros[0][1]*numeros[1][0]);
		Console.WriteLine("El determinante de la matriz |{0} {1}|   es {2}",numeros[0][0],numeros[0][1],determinante);
		Console.WriteLine("                             |{0} {1}|",numeros[1][0],numeros[1][1]);
		Console.WriteLine();
	}
}
