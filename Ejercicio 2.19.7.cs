using System;
class Ejercicio_2197
{
	static void Main()
	{
		int n;
		Console.WriteLine("Introduce el número de un día de la semana:");
		n=Convert.ToInt32(Console.ReadLine());
		switch(n)
		{
			case 1: Console.WriteLine("Lunes"); break;
			case 2: Console.WriteLine("Martes"); break;
			case 3: Console.WriteLine("Miércoles"); break;
			case 4: Console.WriteLine("Jueves"); break;
			case 5: Console.WriteLine("Viernes"); break;
			case 6: Console.WriteLine("Sábado"); break;
			case 7: Console.WriteLine("Domingo"); break;
		}
	}
}
