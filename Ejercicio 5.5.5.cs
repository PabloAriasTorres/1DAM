/*Crea una función "SumarCifras" que reciba un numero cualquiera y que
devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera
123, la suma sería 6.*/
using System;
class Ejercicio_555
{
	static int SumarCifras(int num)
	{
		int total=0;
		string num1=num.ToString();
		for(int i=0; i<num1.Length;i++)
		{
			total=total+Convert.ToInt32(num1[i].ToString());
		}
		return(total);
	}
	
	static void Main()
	{
		int num=0;
		
		Console.WriteLine("Introduce un número:");
		num=Convert.ToInt32(Console.ReadLine());
		SumarCifras(num);
		Console.WriteLine("El total es {0}",SumarCifras(num));
	}
}
