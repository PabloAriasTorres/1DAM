/*Crea una función "MostrarPerimSuperfCuadrado" que reciba un número
entero y calcule y muestre en pantalla el valor del perímetro y de la superficie de
un cuadrado que tenga como lado el número que se ha indicado como parámetro,
sin devolver ningún valor.*/
using System;
class Ejercicio_546
{
	static void MostrarPerimSuperfCuadrado(int lado)
	{
		float perim, super;
		
		perim=lado*4;
		super=lado*lado;
		Console.WriteLine("El perímetro es {0}",perim);
		Console.WriteLine("La superficie es {0}",super);
	}
	
	static void Main()
	{
		int lado=0;
		
		Console.WriteLine("Introduce la medida del lado del cuadrado:");
		lado=Convert.ToInt32(Console.ReadLine());
		MostrarPerimSuperfCuadrado(lado);
	}
}
