/*Crea una función llamada "Signo", que reciba un número real, y devuelva un
número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es
cero*/
using System;
class Ejercicio_543
{
	static int Signo(float num1)
	{
		int valor=0;
		
		if(num1<0) valor=-1;
		if(num1==0) valor=0;
		if(num1>0) valor=1;
		return(valor);
	}
	
	static void Main()
	{
		float num1=0;
		
		Console.WriteLine("Introduce un número:");
		num1=float.Parse(Console.ReadLine());
		Signo(num1);
		Console.WriteLine("El número cambiado es {0}",Signo(num1));
	}
}
