using System;
class Ejercicios_36
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.6.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.6.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_361(); break;
				case 2: Ejercicio_362(); break;
			}
		}
		while(entrar==false);
	}
	/* Crea un programa que permita convertir de millas a metros. El valor
necesario para la conversión debe estar almacenado en una constante.*/
	static void Ejercicio_361()
	{
		const float MILLAS= 1609;
		float metros=0, resultado;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una cantidad de metros para pasarlos a millas:");
				metros=float.Parse(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		resultado=metros/MILLAS;
		Console.WriteLine("{0} metros equivalen a {1} millas",metros,resultado);
		Console.WriteLine();
	}
	/*Crea una enumeración para los meses del año, desde ENERO (con valor 1)
hasta DICIEMBRE (con valor 12). Muestra el valor numérico correspondiente a
OCTUBRE.*/
	enum meses { ENERO=1, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE=12};
	static void Ejercicio_362()
	{
		Console.WriteLine("{0} es el valor de octubre",(int)meses.OCTUBRE);
		Console.WriteLine();
	}
}
