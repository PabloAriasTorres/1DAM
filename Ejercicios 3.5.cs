using System;
class Ejercicios_35
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.5.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.5.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.5.3");
			Console.WriteLine("Escribe 4 para el ejercicio 3.5.4");
			Console.WriteLine("Escribe 5 para el ejercicio 3.5.5");
			Console.WriteLine("Escribe 6 para el ejercicio 3.5.6");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_351(); break;
				case 2: Ejercicio_352(); break;
				case 3: Ejercicio_353(); break;
				case 4: Ejercicio_354(); break;
				case 5: Ejercicio_355(); break;
				case 6: Ejercicio_356(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que use el operador condicional para dar a una variable
llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el
usuario son iguales, o "false" si son distintos.*/
	static void Ejercicio_351()
	{
		int num1=0, num2=0;
		bool ok=false, iguales=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		iguales= num1==num2? true : false;
		if(iguales)
		{
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}	
	}
	/*Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del
operador condicional.*/
	static void Ejercicio_352()
	{
		int num1=0, num2=0;
		bool ok=false, iguales=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		if(num1==num2)
		{
			iguales=true;
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}
	}
	/*Crea una versión alternativa del ejercicio 3.5.1, que asigne directamente el
valor al booleano a partir de una comparación.*/
	static void Ejercicio_353()
	{
		int num1=0, num2=0;
		bool ok=false, iguales=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		iguales= num1==num2;
		if(iguales)
		{
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",iguales);
			Console.WriteLine();
		}	
	}
	/*) Crea un programa que use el operador condicional para dar a una variable
llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por
el usuario son pares, o "false" si alguno es impar.*/
	static void Ejercicio_354()
	{
		int num1=0, num2=0, par1, par2;
		bool ok=false, ambosPares=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		par1=num1%2;
		par2=num2%2;
		ambosPares= par1==par2? true : false;
		if(ambosPares)
		{
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}	
	}
	/*Crea una versión alternativa del ejercicio 3.5.4, que use "if" en vez del
operador condicional.*/
	static void Ejercicio_355()
	{
		int num1=0, num2=0, par1, par2;
		bool ok=false, ambosPares=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		par1=num1%2;
		par2=num2%2;
		if(par1==par2)
		{
			ambosPares=true;
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}
	}
	/*Crea una versión alternativa del ejercicio 3.5.5, que asigne directamente el
valor al booleano a partir de una comparación.*/
	public static void Ejercicio_356()
	{
		int num1=0, num2=0, par1, par2;
		bool ok=false, ambosPares=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				num2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		par1=num1%2;
		par2=num2%2;
		ambosPares= par1==par2;
		if(ambosPares)
		{
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("{0}",ambosPares);
			Console.WriteLine();
		}	
	}
}
