using System;
class Ejercicios_321
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.1.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.1.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3211(); break;
				case 2: Ejercicio_3212(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que muestre el resultado de dividir 3 entre 4, primero
usando números enteros y luego usando números de coma flotante.*/
	static void Ejercicio_3211()
	{
		int num1=3, num2=4, dividir1;
		float num3=3, num4=4, dividir2;
		dividir1=num1/num2;
		dividir2=num3/num4;
		Console.WriteLine("El resultado es {0}",dividir1);
		Console.WriteLine("El resultado es {0}",dividir2);
		Console.WriteLine();
	}
	/* ¿Cuál sería el resultado de las siguientes operaciones, usando números
reales? a=5; a/=2; a+=1; a*=3; --a;*/
	static void Ejercicio_3212()
	{
		int a=5;
		a/=2;
		Console.WriteLine("a/=2 es {0}",a);
		a+=1;
		Console.WriteLine("a+=1 es {0}",a);
		a*=3;
		Console.WriteLine("a*=3 es {0}",a);
		--a;
		Console.WriteLine("--a es {0}",a);
		Console.WriteLine();
	}
}
