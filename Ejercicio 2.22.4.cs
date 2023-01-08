/*Crea un programa que pida al usuario su identificador y su contraseña
(ambos numéricos), y no le permita seguir hasta que introduzca como
identificador "1234" y como contraseña "1111".*/
using System;
class Ejercicio_2224
{
	static void Main()
	{
		int identificador, contra;
		do
		{
			Console.WriteLine("Introduce tu identificador:");
			identificador=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Introduce tu contraseña:");
			contra=Convert.ToInt32(Console.ReadLine());
			if((identificador!=1234)&&(contra!=1111))
			{
				Console.WriteLine("Error: Vuelva a intentarlo");
			}
		}
		while((identificador!=1234)&&(contra!=1111));
		{
			Console.WriteLine("Correcto");
		}
	}
}
				
			
