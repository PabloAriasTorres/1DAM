using System;
class Ejercicios_46
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
				Console.WriteLine("Escribe 2 para el ejercicio 4.6.2");
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
				case 1: break;
				case 2: Ejercicio_462(); break;
			}
		}
		while(entrar==false);
	}
/*Un programa que pida datos de 8 personas: nombre, día de nacimiento,
mes de nacimiento, y año de nacimiento (que se deben almacenar en un array de
structs). Después deberá repetir lo siguiente: preguntar un número de mes y
mostrar en pantalla los datos de las personas que cumplan los años durante ese
mes. Terminará de repetirse cuando se teclee 0 como número de mes*/
	struct caracPersona
	{
		public string nombre;
		public int dia_nac;
		public int mes_nac;
		public int anyo_nac;
	}
	static void Ejercicio_462()
	{
		caracPersona[] personas = new caracPersona[8];
		
		for( int i=0; i<personas.Length; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce el nombre de la persona {0}:",i+1);
					personas[i].nombre=Console.ReadLine();
					if(personas[i].nombre=="") throw new Exception("Error: este campo no puede estar vacío");
					Console.WriteLine("Introduce el día de nacimiento:");
					personas[i].dia_nac=Convert.ToInt32(Console.ReadLine());
					if(personas[i].dia_nac<1 || personas[i].dia_nac>31) throw new Exception("Error: los días de los meses van desde 1 hasta 31(como máximo)");
					Console.WriteLine("Introduce el mes de nacimiento:");
					personas[i].mes_nac=Convert.ToInt32(Console.ReadLine());
					if(personas[i].mes_nac<1 || personas[i].mes_nac>12) throw new Exception("Error: los meses van del 1 hasta el 12");
					Console.WriteLine("Introduce el año de nacimiento:");
					personas[i].anyo_nac=Convert.ToInt32(Console.ReadLine());
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
		}
		
		int mes_buscado=0;
		bool encontrado=false;;
		
		while(true)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un mes para buscar las personas que hayan nacido en ese mes(0 para salir):");
					mes_buscado=Convert.ToInt32(Console.ReadLine());
					if(mes_buscado<0 || mes_buscado>12) throw new Exception("Error: los meses van del 1 hasta el 12");
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
			if(mes_buscado!=0)
			{
				for( int i=0; i<personas.Length; i++)
				{
					if(mes_buscado==personas[i].mes_nac)
					{ 
						Console.WriteLine("{0}",personas[i].nombre);
						encontrado=true;
					}
				}
				if(encontrado==false) Console.WriteLine("No se han encontrado");
			}
			if(mes_buscado==0) break;
		}
	}
}
