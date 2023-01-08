using System;
class Ejercicios_322
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.2.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.2.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3221(); break;
				case 2: Ejercicio_3222(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que muestre el resultado de dividir 13 entre 6 usando
números enteros, luego usando números de coma flotante de simple precisión y
luego con números de doble precisión.*/
	static void Ejercicio_3221()
	{
		int num1=13, num2=6, dividir1;
		float num3=13, num4=6, dividir2;
		double num5=13, num6=6, dividir3;
		dividir1=num1/num2;
		dividir2=num3/num4;
		dividir3=num5/num6;
		Console.WriteLine("El resultado es {0}",dividir1);
		Console.WriteLine("El resultado es {0}",dividir2);
		Console.WriteLine("El resultado es {0}",dividir3);
		Console.WriteLine();
	}
	/*Calcula el área de un círculo, dado su radio, que será un número entero
(área = pi * radio al cuadrado). Usa datos de doble precisión.*/
	static void Ejercicio_3222()
	{
		int radio=0;
		double área;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el radio del círculo:");
				radio=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: No es un valor válido");
			}
		}
		while(ok==false);
		área=3.14*(radio*radio);
		Console.WriteLine("El área del círculo es {0}",área);
		Console.WriteLine();
	}
}
		
		
