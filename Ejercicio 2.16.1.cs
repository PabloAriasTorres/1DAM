using System;
class Ejercicio_2161
{
 static void Main()
 {
	int numero;
	Console.WriteLine("Introduce un número");
	numero = Convert.ToInt32(Console.ReadLine());
	if (0==numero)
		Console.WriteLine("El número es cero.");
	else
		if (0>numero)
			Console.WriteLine("El número es negativo.");
		else
			Console.WriteLine("El número es positivo.");
 }
}
