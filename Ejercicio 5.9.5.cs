/*) Crea un programa que emplee recursividad para calcular el mayor de los
elementos de un vector. El planteamiento será muy similar al del ejercicio anterior*/
using System;
class Ejercicio_595
{
	static int Mayor(int[] numeros, int mayor, int pos_ini, int pos_fin)
	{
		if(mayor < numeros[pos_ini]) mayor=numeros[pos_ini];
		if(numeros[pos_ini]==numeros[pos_fin-1]) return mayor;
		return Mayor(numeros,mayor,++pos_ini,pos_fin);
	}
	
	static void Main()
	{
		int[] numeros = new int[6];
		int pos_ini=0, pos_fin=6;
		bool ok=false;
		
		for(int i=0; i<numeros.Length; i++)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		int mayor=numeros[0];
		Console.WriteLine("El mayor de todos es {0}",Mayor(numeros,mayor,pos_ini,pos_fin));
	}
}
