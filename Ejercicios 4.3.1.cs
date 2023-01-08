/*Crea un "struct" que almacene datos de una canción en formato MP3:
Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa
debe pedir los datos de una canción al usuario, almacenarlos en dicho "struct" y
después mostrarlos en pantalla.*/
using System;
class Ejercicio_4311
{
	struct caracteristicasCancion
	{
		public string nombre;
		public float duracion;
		public string titulo;
		public int tamanyo;
	}
	static void Main()
	{
		caracteristicasCancion cancion;
		cancion.duracion=0;
		cancion.tamanyo=0;
		
		Console.WriteLine("Introduce el nombre del artista:");
		cancion.nombre=Console.ReadLine();
		Console.WriteLine("Introduce el título de la canción:");
		cancion.titulo=Console.ReadLine();
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la duración de la canción:");
				cancion.duracion=float.Parse(Console.ReadLine());
				Console.WriteLine("Introduce el tamaño en KB de la canción:");
				cancion.tamanyo=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		Console.WriteLine("El nombre del artista es {0}, el título de la canción es {1}, la canción dura {2} minutos y el tamaño de la canción es {3}KB",cancion.nombre,cancion.titulo,cancion.duracion,cancion.tamanyo);
		
	}
}
