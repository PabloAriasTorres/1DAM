/*Crea un programa que pida un número al usuario y escriba los múltiplos
de 9 que haya entre 1 y ese número. Debes usar llaves en todas las estructuras de
control, aunque sólo incluyan una sentencia.*/
using System;
class Ejercicio_2291
{
	static void Main()
	{
		int n, multiplo;
		Console.WriteLine("Introduce un número:");
		n=Convert.ToInt32(Console.ReadLine());
		for(int m=1; m<=n; m++)
		{
			multiplo=m%9;
			if(multiplo==0)
			{
				Console.WriteLine("{0} es múltiplo de 9",m);
			}
		}
	}
}
			
