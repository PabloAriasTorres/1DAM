/* Crea dos funciones que sirvan para saber si un cierto texto es subcadena de
una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar letra
a letra. Una función debe ser iterativa y la otra debe ser recursiva.*/
using System;
class Ejercicio_599
{
	static bool Subcadena(string cadena, string subcadena, int contador)
	{
		bool encontrado;
		string vacia="";
		if(cadena.Length!=0)
		{
			if(contador==subcadena.Length)
			{
				encontrado=true;
				return encontrado;
			}
			for(int i=1; i<cadena.Length; i++)
			{
				vacia=vacia+cadena[i];
			}
			if(cadena[0]==subcadena[contador])
			{
				contador++;
			}
			else contador=0;
			return Subcadena(vacia,subcadena,contador);
		}
		else
		{
			encontrado=false;
			return encontrado;
		}
	}
	
	static void Main()
	{
		string cadena="", subcadena="";
		int contador=0;
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Console.WriteLine("Introduce una subcadena:");
		subcadena=Console.ReadLine();
		
		
		if(Subcadena(cadena,subcadena,contador)) Console.WriteLine("Si que es subcadena");
		else Console.WriteLine("No es subcadena");
	}
}

/*class Ejercicio_Sin_Recursividad
{
	static void Main()
	{
		string cadena="", subcadena="";
		int contador=0, contador2=0;
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Console.WriteLine("Introduce una subcadena:");
		subcadena=Console.ReadLine();
		
		for(int i=0; i<subcadena.Length; i++)
		{
			contador++;
		}
		for(int i=0; i<cadena.Length; i++)
		{
			if (contador!=contador2)
			{
				if(cadena.ToLower()[i]==subcadena.ToLower()[contador2])
				{
					contador2++;
				}
				else contador2 = 0;
			}
		}
		if(contador==contador2) Console.WriteLine("Si hay subcadena");
		else Console.WriteLine("No hay subcadena");
	}
}*/
