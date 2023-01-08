/*Crea una función "Menor" que calcule el menor de dos números enteros
que recibirá como parámetros. El resultado será otro número entero.*/
using System;
class Ejercicio_542
{
	static int Menor(int num1, int num2)
	{
		int menor;
		
		menor=num1;
		if(num2<num1) menor=num2;
		return(menor);
	}
	
	static void Main()
	{
		int num1=0, num2=0;
		
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		Menor(num1, num2);
		Console.WriteLine("El menor de los dos es {0}",Menor(num1,num2));
	}
}
