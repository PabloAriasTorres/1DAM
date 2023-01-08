using System;
class Ejercicios_327
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.7.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.7.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.2.7.3");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3271(); break;
				case 2: Ejercicio_3272(); break;
				case 3: Ejercicio_3273(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que halle (y muestre) la raíz cuadrada del número que
introduzca el usuario. Se repetirá hasta que introduzca 0.*/
	static void Ejercicio_3271()
	{
		int num=1, resultado;
		bool ok=false;
		while(num!=0)
		{
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					num=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine();
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			if(num!=0)
			{
				resultado=(int)Math.Sqrt(num);
				Console.WriteLine("El resultado es {0}",resultado);
				Console.WriteLine();
			}
			else
			{
				break;
			}
		}
	}
	/*Diseña un programa que calcule cualquier raíz (de cualquier orden) de un
número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz
(por ejemplo, 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que
elevar 2 a 1/3.*/
	static void Ejercicio_3272()
	{
		double num=0, raiz=0, resultado;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el índice de la raíz:");
				raiz=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		resultado=Math.Pow(num,1/raiz);
		Console.WriteLine("El resultado es {0}",resultado);
		Console.WriteLine();
	}
	/*Crea un programa que calcule la distancia entre dos puntos (x1,y1) y (x2,y2),
usando la expresión d = raíz [ (x1-x2)2+ (y1-y2)2].*/
	static void Ejercicio_3273()
	{
		double x1=0, x2=0, y1=0, y2=0, resultado;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la primera coordenada del primer punto:");
				x1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la segunda coordenada del primer punto:");
				x2=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la primera coordenada del segundo punto:");
				y1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la segunda coordenada del segundo punto:");
				y2=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		resultado= Math.Sqrt( Math.Pow(y1-x1,2)+ Math.Pow(y2-x2,2));
		Console.WriteLine("El resultado es {0}",resultado);
		Console.WriteLine();
	}
}
