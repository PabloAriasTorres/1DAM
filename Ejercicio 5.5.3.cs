/*Crea una función "EsPrimo", que reciba un número y devuelva el valor
booleano "true" si es un número primo o "false" en caso contrario.*/
using System;
class Ejercicio_553
{
	static bool EsPrimo(int num)
	{
		bool primo=true;
		
		for(int i=0; i<num; i++)
		{
			int j=2;
			if(num==1 || num==2)
			{
				primo=true;
				break;
			}
			if(num%j==0)
			{
				primo=false;
				break;
			}
			else j++;
		}
		return(primo);
	}
	
	static void Main()
	{
		int num=0;
		Console.WriteLine("Introduce un número:");
		num=Convert.ToInt32(Console.ReadLine());
		EsPrimo(num);
		Console.WriteLine("{0}",EsPrimo(num));
	}
}
