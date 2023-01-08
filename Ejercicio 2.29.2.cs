/*Crea un programa que pida al usuario dos números y escriba sus
divisores comunes. Debes usar llaves en todas las estructuras de control, aunque
sólo incluyan una sentencia.*/
using System;
class Ejercicio_2292
{
	static void Main()
	{
		int num1, num2, divisor1, divisor2;
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		for(int m=1; m<=num1; m++)
		{
			divisor1=num1%m;
			if(divisor1==0)
			{
				Console.WriteLine("{0} es divisor de {1}",m,num1);
			}
		}
		Console.WriteLine();
		for(int m=1; m<=num2; m++)
		{
			divisor2=num2%m;
			if(divisor2==0)
			{
				Console.WriteLine("{0} es divisor de {1}",m,num2);
			}
		}
	}
}
			
