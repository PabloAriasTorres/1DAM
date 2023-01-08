using System;
class Ejercicios_312
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.1.2.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.1.2.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.1.2.3");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3121(); break;
				case 2: Ejercicio_3122(); break;
				case 3: Ejercicio_3123(); break;
			}
		}
		while(entrar==false);
	}
/*Pregunta al usuario su edad, que se guardará en un "byte". A
continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No
aparentas 20 años").*/	
	static void Ejercicio_3121()
	{
		byte edad=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce tu edad:");
				edad=Convert.ToByte(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("No es un valor válido");
			}
		}
		while(ok==false);
		Console.WriteLine("No aparentas {0} años",edad);
		Console.WriteLine();
	}
	/*Pide al usuario dos números de dos cifras ("byte"), calcula su
multiplicación, que se deberá guardar en un "int", y muestra el resultado en
pantalla*/
	static void Ejercicio_3122()
	{
		byte num1=0;
		byte num2=0;
		int producto;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num1=Convert.ToByte(Console.ReadLine());
				Console.WriteLine("Introduce otro número:");
				num2=Convert.ToByte(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("No es un valor válido");
			}
		}
		while(ok==false);
		producto=num1*num2;
		Console.WriteLine("El resultado de multiplicar {0}x{1} es {2}",num1,num2,producto);
		Console.WriteLine();
	}
	/*Pide al usuario dos números enteros largos ("long") y muestra su suma,
su resta y su producto.*/
	static void Ejercicio_3123()
	{
		long num1=0, num2=0, suma, resta, producto;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num1=Convert.ToByte(Console.ReadLine());
				Console.WriteLine("Introduce otro número:");
				num2=Convert.ToByte(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("No es un valor válido");
			}
		}
		while(ok==false);
		suma=num1+num2;
		resta=num1-num2;
		producto=num1*num2;
		Console.WriteLine("La suma es {0}, la resta es {1} y el producto es {2}",suma,resta,producto);
		Console.WriteLine();
	}
}
