/*) Crea una función "MaxMinArray", que reciba un array de reales de doble
precisión y devuelva el mayor valor almacenado en ese array y el menor, utilizando
parámetros por referencia. Pruébala con un "Main" adecuado.*/
using System;
class Ejercicio_5723
{
	static void MaxMinArray(ref double[] numeros, ref double mayor, ref double menor)
	{
		for(int i=0; i<numeros.Length; i++)
		{
			if(numeros[i]>mayor)
			{
				mayor=numeros[i];
			}
			if(numeros[i]<menor)
			{
				menor=numeros[i];
			}
		}
	}
	
	static void Main()
	{
		double[] numeros = new double[6];
		
		for(int i=0; i<numeros.Length; i++)
		{
			Console.WriteLine("Introduce un número:");
			numeros[i]=Convert.ToDouble(Console.ReadLine());
		}
		double mayor=numeros[0], menor=numeros[0];
		MaxMinArray(ref numeros, ref mayor, ref menor);
		Console.WriteLine("El mayor es {0} y el menor es {1}",mayor,menor);
	}
}
