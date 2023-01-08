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
			Console.WriteLine("Escribe 1 para el ejercicio 4.1.5.1");
			Console.WriteLine("Escribe 2 para el ejercicio 4.1.5.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_4151(); break;
				case 2: Ejercicio_4152(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que contenga un array con los nombres de los meses
del año. El usuario podrá elegir entre verlos en orden natural (de Enero a
Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el
valor máximo del array en ambos recorridos.*/
	static void Ejercicio_4151()
	{
		const int MAXIMO= 12;
		string[] nombres={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
		int n=0;
		
		Console.WriteLine("Pulsa 1 para verlos ordenados");
		Console.WriteLine("Pulsa 2 para verlos de forma inversa");
		Console.WriteLine();
		Console.WriteLine("Introduce 1 o 2 para ver los meses:");
		n=Convert.ToInt32(Console.ReadLine());
		
		switch(n)
		{
			case 0: break;
			case 1: 
				for( int i=0; i<MAXIMO; i++)
				{
					Console.Write("{0} ",nombres[i]);
				}
				Console.WriteLine();
				break;
			case 2:
				for( int i=MAXIMO-1; i>=0; i--)
				{
					Console.Write("{0} ",nombres[i]);
				}
				Console.WriteLine();
				break;
		}
		
	}
	/*Crea una nueva versión del ejercicio 4.1.5.1, usando ".Length" en vez de
una constante.*/
	static void Ejercicio_4152()
	{
		string[] nombres={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
		int n=0;
		
		Console.WriteLine("Pulsa 1 para verlos ordenados");
		Console.WriteLine("Pulsa 2 para verlos de forma inversa");
		Console.WriteLine();
		Console.WriteLine("Introduce 1 o 2 para ver los meses:");
		n=Convert.ToInt32(Console.ReadLine());
		
		switch(n)
		{
			case 0: break;
			case 1: 
				for( int i=0; i<nombres.Length; i++)
				{
					Console.Write("{0} ",nombres[i]);
				}
				Console.WriteLine();
				break;
			case 2:
				for( int i=nombres.Length-1; i>=0; i--)
				{
					Console.Write("{0} ",nombres[i]);
				}
				Console.WriteLine();
				break;
		}
	}
}
