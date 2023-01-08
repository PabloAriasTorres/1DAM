/* Crea una función "MaxMinArray", parecida a la del ejercicio 5.7.2.3, que
reciba un array de reales de doble precisión y devuelva el mayor valor almacenado
en ese array y el menor, utilizando parámetros de salida. Pruébala con un "Main"
adecuado.*/
using System;
class Ejercicio_5732
{
	static void MaxMinArray(double[] numeros, out double mayor, out double menor)
	{
		mayor = numeros[0];
		menor = numeros[0];
		
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
		double mayor, menor;
		MaxMinArray(numeros, out mayor, out menor);
		Console.WriteLine("El mayor es {0} y el menor es {1}",mayor,menor);
	}
}
