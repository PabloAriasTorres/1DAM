/*Crea un programa que pida al usuario dos números y escriba su mínimo
común múltiplo (pista: una solución lenta pero sencilla es probar con un "for"
todos los números a partir del mayor de ambos, de forma creciente; cuando
encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda con
"break").*/
using System;
class Ejercicio_22102
{
	static void Main()
	{
		int num1, num2, i, mayor;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		mayor= num1>num2 ? num1:num2;
		for( i=mayor; i>=1; i++)
		{
			if((i%num1==0) && (i%num2==0))
			{
				Console.WriteLine("El mínimo común múltiplo es {0}",i);
				break;
			}
		}
	}
}
