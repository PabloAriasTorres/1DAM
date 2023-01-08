/* Crea un programa que pida al usuario dos números y escriba su máximo
común divisor (pista: una solución lenta pero sencilla es probar con un "for" todos
los números descendiendo a partir del menor de ambos, hasta llegar a 1; cuando
encuentres un número que sea divisor de ambos, interrumpe la búsqueda con
"break").*/
using System;
class Ejercicio_22101
{
	static void Main()
	{
		int num1, num2, menor, i;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		menor= num1<num2 ? num1:num2;
		for( i=menor; i>=1; i--)
		{
			if((num1%i==0) && (num2%i==0))
			{
				Console.WriteLine("El máximo común divisor es {0}",i);
				break;
			}
		}
	}
} 
		
