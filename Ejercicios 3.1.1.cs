/*Calcula el producto de 1.000.000 por 1.000.000, usando una variable
llamada "producto", de tipo "long". Prueba también a calcularlo usando una
variable de tipo "int".*/
using System;
class Ejercicio_3111
{
	static void Main()
	{
		long producto;
		producto=(long)1000000*(long)1000000;
		Console.WriteLine("El resultado de es {0}",producto);
	}
}
