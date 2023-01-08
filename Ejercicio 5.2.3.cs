/* Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de
modo que el "Main" sea breve y más legible (Pista: las variables que se compartan
entre varias funciones deberán estar fuera de todas ellas, y deberán estar
precedidas por la palabra "static").*/
using System;
class Ejercicio_523
{
	struct tipoFicha
	{
		public string nombreFich;
		public long tamanyo;
	}
	
	static void Main()
	{
		int numeroFichas=0;
	    tipoFicha[] fichas = new tipoFicha[1000];
	    long tamanyoBuscar=0;
		int opcion;
		bool ok=false;
		
		do
		{
			PedirOpcion();
			opcion=Convert.ToInt32(Console.ReadLine());
			switch(opcion)
			{
				case 1: numeroFichas = Anyadir(fichas, numeroFichas); break;
				case 2: MostrarTodo(fichas, numeroFichas); break;
				case 3: MostrarTam(tamanyoBuscar,numeroFichas,fichas); break;
				case 4: UnFichero(numeroFichas,fichas); break;
				case 5: ok=true; break;
			}
		}
		while(ok==false);
	}
	
	static void PedirOpcion()
	{
		Console.WriteLine("Escoja una opción:");
		Console.WriteLine("1.- Añadir datos de un nuevo fichero");
		Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
		Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
		Console.WriteLine("4.- Ver datos de un fichero");
		Console.WriteLine("5.- Salir");
	}
	
	static int Anyadir(tipoFicha[] fichas, int numeroFichas)
	{
		if (numeroFichas < 1000)
		{
			Console.WriteLine("Introduce el nombre del fichero: ");
			fichas[numeroFichas].nombreFich = Console.ReadLine();
			Console.WriteLine("Introduce el tamaño en KB: ");
			fichas[numeroFichas].tamanyo = Convert.ToInt32(
			Console.ReadLine() );
		}
		else
		{
			Console.WriteLine("Máximo de fichas alcanzado (1000)!");
		}
		return(++ numeroFichas);
	}
	
	static void MostrarTodo(tipoFicha[] fichas, int numeroFichas)
	{
		for (int i=0; i<numeroFichas; i++)
		{
			Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
			fichas[i].nombreFich, fichas[i].tamanyo);
		}
	}
	
	static void MostrarTam(long tamanyoBuscar, int numeroFichas, tipoFicha[] fichas)
	{
		Console.WriteLine("¿A partir de que tamaño quieres ver?");
		tamanyoBuscar = Convert.ToInt64( Console.ReadLine() );
		for (int i=0; i < numeroFichas; i++)
		if (fichas[i].tamanyo >= tamanyoBuscar)
		Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
		fichas[i].nombreFich, fichas[i].tamanyo);
	}
	
	static void UnFichero(int numeroFichas, tipoFicha[] fichas)
	{
		string textoBuscar="";
		Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
		textoBuscar = Console.ReadLine();
		for (int i=0; i < numeroFichas; i++)
		{
			if ( fichas[i].nombreFich == textoBuscar )
			{
				Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
				fichas[i].nombreFich, fichas[i].tamanyo);
			}
		}
	}
}
