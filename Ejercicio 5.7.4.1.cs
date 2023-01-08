/*Crea un programa que te pida tu edad tantas veces como sea necesario,
hasta que introduzcas un valor numérico aceptable.*/
using System;
class Ejercicio_5741
{
	static void Main()
	{
		int edad=0;
		bool ok=false;
		
		while(ok==false)
		{
			Console.WriteLine("Introduce tu edad:");
			if(Int32.TryParse(Console.ReadLine(), out edad))
			{
				Console.WriteLine("Tu edad es {0}",edad);
				ok=true;
			}
			else
			{
				Console.WriteLine("Repite tu edad");
			}
		}
	}
}
