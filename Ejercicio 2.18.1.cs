/*Crea un programa que use el operador condicional para mostrar el valor
absoluto de un número de la siguiente forma: si el número es positivo, se
mostrará tal cual; si es negativo, se mostrará cambiado de signo.*/
using System;
class Ejercicio_2181
{
	static void Main()
	{
		int n1, n2, absoluto;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		n2=n1*(-1);
		absoluto= n1>=0 ? n1 : n2;
		if(absoluto==n1)
		{
			Console.WriteLine("|{0}| = {1}",n1,absoluto);
		}
		else
		{
			Console.WriteLine("|{0}|",n2,absoluto);
		}
	}
}
