using System;
class Ejercicios_34
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.4.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.4.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_341(); break;
				case 2: Ejercicio_342(); break;
			}
		}
		while(entrar==false);
	}
	/* Crea un programa que pida al usuario su nombre, y le diga "Hola" si se
llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.*/
	static void Ejercicio_341()
	{
		int entrar_al_while=1;
		string nombre="Pepe";
		bool ok=false;
		while(entrar_al_while==1)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce tu nombre:");
					nombre=Console.ReadLine();
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			if(nombre=="Juan")
			{
				Console.WriteLine("Hola");
				Console.WriteLine();
				entrar_al_while=0;
			}
			else
			{
				Console.WriteLine("No te conozco");
				Console.WriteLine();
			}
	    }
	}
	/*Crea un programa que pida al usuario un nombre y una contraseña. La
contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se
avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como
sea necesario hasta que coincidan.*/
	static void Ejercicio_342()
	{
		string contra1="a", contra2="a", nombre="a";
		bool ok=false;
		int entrar_al_while=1;
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		while(entrar_al_while==1)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce la contraseña:");
					contra1=Console.ReadLine();
					Console.WriteLine("Introduce la contraseña otra vez:");
					contra2=Console.ReadLine();
					if(contra2!=contra1) throw new Exception(" las dos contraseñas tienen que ser iguales");
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
			if(contra1==contra2)
			{
				Console.WriteLine("Perfecto");
				entrar_al_while=0;
				Console.WriteLine();
			}
	    }
	}
}
