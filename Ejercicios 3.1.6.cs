/*Crea un programa que pida al número del 0 al 255 y muestre el resultado
de hacer un XOR con un cierto dato prefijado (y también en ese rango).
Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor
5 = 131).*/
using System;
class Ejercicio_3161
{
	static void Main()
	{
		int num1=1, xor=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número entre el 0 y el 255:");
				num1=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("No es un valor válido");
			}
		}
		while(ok==false);
		if(num1<0 || num1>255)
		{
			Console.WriteLine("Error: el número tiene que ser mayor que 0 y menor que 255");
		}
		else
		{
			xor=num1^5;
			Console.WriteLine("El resultado es {0}",xor);
		}
    }
}
		
