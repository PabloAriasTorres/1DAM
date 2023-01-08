/*Crea un programa que pida al usuario su identificador y su contraseña, y
no le permita seguir hasta que introduzca como nombre "Pedro" y como
contraseña "Peter".*/
using System;
class Ejercicio_2224
{
	static void Main()
	{
		string identificador, contra;
		string correcta="Pedro";
		string correcta2="Peter";
		do
		{
			Console.WriteLine("Introduce tu identificador:");
			identificador=Console.ReadLine();
			Console.WriteLine("Introduce tu contraseña:");
			contra=Console.ReadLine();
			if((identificador!=correcta)&&(contra!=correcta2))
			{
				Console.WriteLine("Error: Vuelva a intentarlo");
			}
		}
		while((identificador!=correcta)&&(contra!=correcta2));
		{
			Console.WriteLine("Correcto");
		}
	}
}
