using System;
class Ejercicio_22111
{
	static void Main()
	{
		int contra, correcta=1111;
		Console.WriteLine("Introduce tu contraseña:");
		contra=Convert.ToInt32(Console.ReadLine());
		while(contra!=correcta)
		{
			Console.WriteLine("Contraseña incorrecta vuelve a intentarlo");
			Console.WriteLine("Introduce tu contraseña:");
			contra=Convert.ToInt32(Console.ReadLine());
			if(contra==correcta)
			{
			Console.WriteLine("Contraseña correcta");
			}	
		}
	}
}
		
