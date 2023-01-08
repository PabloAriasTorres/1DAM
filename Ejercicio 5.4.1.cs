/* Crea una función "Cubo" que calcule el cubo de un número real (float) que
se indique como parámetro. El resultado deberá ser otro número real. Prueba esta
función para calcular el cubo de 3.2 y el de 5.*/
using System;
class Ejercicio_541
{
	static float Cubo(float cubo)
	{
		float total;
		total=cubo*cubo*cubo;
		return(total);
	}
	
	static void Main()
	{
		float cubo=0;
		
		Console.WriteLine("Introduce un número:");
		cubo=float.Parse(Console.ReadLine());
		Cubo(cubo);
		Console.WriteLine("El cubo de {0} es {1}",cubo,Cubo(cubo));
	}
}
