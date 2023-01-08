/* Usa el operador condicional para calcular el menor de dos números.*/
using System;
class Ejercicio_2182
{
	static void Main()
	{
		int n1, n2, resultado;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		resultado= n1>n2 ? n1 : n2;
		if( resultado==n1)
		{
			Console.WriteLine("{0} es el menor de los dos",n2);
		}
		else
		{
			Console.WriteLine("{0} es el menor de los dos",n1);
		}
	}
}
