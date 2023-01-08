/*Crea un programa que emplee recursividad para calcular la suma de los
elementos de un vector de números enteros, desde su posición inicial a la final,
usando una función recursiva que tendrá la apariencia: SumaVector(v, desde,
hasta). Nuevamente, piensa cuál será el caso base (cuántos elementos podrías
sumar para que dicha suma sea trivial) y cómo pasar del caso "n-1" al caso "n" (por
ejemplo, si conoces la suma de los 6 primeros elementos y el valor del séptimo
elemento, cómo podrías emplear esta información para conocer la suma de los 7
primeros).*/
using System;
class Ejercicio_594
{
	static int SumaVector(int[] vectores, int pos_ini, int pos_fin)
	{
		if(vectores[pos_ini]==vectores[pos_fin-1]) return vectores[pos_ini];
		
		return vectores[pos_ini]+SumaVector(vectores,++pos_ini,pos_fin);
	}
	
	static void Main()
	{
		int[] vectores = new int[6];
		int pos_ini=0, pos_fin=6;
		bool ok=false;
		
		for(int i=0; i<vectores.Length; i++)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					vectores[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		Console.WriteLine("La suma es {0}",SumaVector(vectores,pos_ini,pos_fin));
	}
}
