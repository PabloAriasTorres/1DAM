using System;
class Ejercicios_324
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.4.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.4.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3241(); break;
				case 2: Ejercicio_3242(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que calcule la raíz cuadrada del número que
introduzca el usuario. La raíz se deberá calcular como "double", pero el resultado
se mostrará como "float". (Recuerda: como viste al hacer el ejercicio 3.2.3.3, la raíz
cuadrada de un número x se calcula con Math.Sqrt(x)).*/
	static void Ejercicio_3241()
	{
		double x=0;
		float resultado;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				x=Convert.ToDouble(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		resultado=(float)Math.Sqrt(x);
		Console.WriteLine("El resultado es {0}",resultado);
	}
	/*Crea una nueva versión del programa que calcula una aproximación de PI
mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...) con tantos
términos como indique el usuario. Debes hacer todas las operaciones con
"double", pero mostrar el resultado como "float".*/
	static void Ejercicio_3242()
	{
			double pi, contador=1, num=0, salir_while=0, contador2=3;
			float total=0;
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce una cantidad de términos:");
					num=Convert.ToDouble(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			while(salir_while!=num)
			{
				pi=+(1/contador)-(1/contador2);
				total=(float)pi+(float)total;
				contador+=4;
				contador2+=4;
				salir_while++;
			}
			total=4*(float)total;
			Console.WriteLine("El resultado es {0}",total);
	}
}
