/*Crea una función "Intercambiar", que intercambie el valor de los dos
números enteros que se le indiquen como parámetro. Crea también un programa
que la pruebe.*/
using System;
class Ejercicio_5721
{
	static void Intercambiar(ref int num1, ref int num2)
	{
		int valortemp=0;
		valortemp=num1;
		num1=num2;
		num2=valortemp;
	}
	
	static void Main()
	{
		int num1=0, num2=0;
		
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Num1 vale {0} y Num2 vale {1}",num1,num2);
		Intercambiar(ref num1,ref num2);
		Console.WriteLine("Ahora num1 vale {0} y num2 vale {1}",num1,num2);
	}
}
