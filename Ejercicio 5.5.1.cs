/*Crea una función "PedirEntero", que reciba como parámetros el texto que
se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo
aceptable. Esta función deberá pedir al usuario que introduzca el valor, tantas
veces como sea necesario, deberá volvérselo a pedir en caso de error, y deberá
devolver un valor correcto. Pruébalo con un programa que pida al usuario un año
entre 1800 y 2100.*/
using System;
class Ejercicio_551
{
	static void PedirEntero(string cadena, int valmin, int valmax)
	{
		int valor=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un valor entre 1800 y 2100:");
				valor=Convert.ToInt32(Console.ReadLine());
				if(valor<valmin || valor>valmax) throw new Exception("Error:debe ser mayor que 1800 y menor 2100");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		Console.WriteLine("{0}",valor);
	}
	
	static void Main()
	{
		int valmin=1800, valmax=2100;
		string cadena="Años de la época Mesopotámica";
		PedirEntero(cadena,valmin,valmax);
	}
}
