using System;
class Ejercicio_1124
{
	static void Main()
	{
		float celsius, kelvin, fahrenheit;
		Console.WriteLine("Introduce una cantidad de grados Celsius");
		celsius=Convert.ToInt32( Console.ReadLine());
		kelvin=celsius+273;
		fahrenheit=celsius*18/10+32;
		Console.Write(celsius);
		Console.Write("C=");
		Console.Write(kelvin);
		Console.WriteLine("K");
		Console.Write(celsius);
		Console.Write("C=");
		Console.Write(fahrenheit);
		Console.Write("F");
	}
}
		
