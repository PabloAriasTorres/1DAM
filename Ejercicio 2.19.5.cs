using System;
class Ejercicio_2195
{
	static void Main()
	{
		char letra;
		Console.WriteLine("Introduce una letra:");
		letra=Convert.ToChar(Console.ReadLine());
		if((letra>='0')&&(letra<='9'))
		{
			Console.WriteLine("Número");
		}
		if((letra=='.')||(letra==':')||(letra==',')||(letra==';'))
		{
			Console.WriteLine("Signo de puntuación");
		}
		if((letra==' '))
		{
			Console.WriteLine("Espacio");
		}
	}
}
