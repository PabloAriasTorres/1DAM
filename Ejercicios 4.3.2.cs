using System;
class Ejercicios_432
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.3.2.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.3.2.2");
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
				case 1: Ejercicio_4321(); break;
				case 2: break;
			}
		}
		while(entrar==false);
	}
	/*Amplia el programa del ejercicio 4.3.1.1, para que almacene datos de
hasta 100 canciones. Deberá tener un menú que permita al usuario realizar las
opciones: añadir una nueva canción, mostrar el título de todas las canciones,
buscar la canción que contenga un cierto texto (en el artista o en el título).
Recuerda que el array estará sobredimensionado, así que deberás llevar un
contador de la cantidad de datos que hay almacenados hasta el momento.*/
	struct caracteristicasCancion
	{
		public string nombre;
		public float duracion;
		public string titulo;
		public int tamanyo;
	}
	static void Ejercicio_4321()
	{
		caracteristicasCancion[] cancion= new caracteristicasCancion[100];
		int cantidad=0, n=0;
		
		Console.WriteLine("Pulsa 0 para salir");
		Console.WriteLine("Pulsa 1 para añadir una nueva canción");
		Console.WriteLine("Pulsa 2 para buscar una canción");
		Console.WriteLine();
		Console.WriteLine("Introduce el número del apartado que quieras:");
		n=Convert.ToInt32(Console.ReadLine());
		switch(n)
		{
			case 0: break;
			case 1:
				for( int i=0;i<100; i++)
				{
					Console.WriteLine("Introduce el nombre del artista( hola para parar el programa):");
					cancion[i].nombre=Console.ReadLine();
					cantidad++;
					if(cancion[i].nombre=="hola")
					{
						cantidad--;
						break;
					}
					Console.WriteLine("Introduce el título de la canción:");
					cancion[i].titulo=Console.ReadLine();
					bool ok=false;
					do
					{
						try
						{
							Console.WriteLine("Introduce la duración de la canción:");
							cancion[i].duracion=float.Parse(Console.ReadLine());
							Console.WriteLine("Introduce el tamaño de la canción en KB:");
							cancion[i].tamanyo=Convert.ToInt32(Console.ReadLine());
							ok=true;
						}
						catch(FormatException)
						{
							Console.WriteLine("Error: no es un valor válido");
						}
					}
					while(ok==false);
				}
				break;
		}
	}
}
