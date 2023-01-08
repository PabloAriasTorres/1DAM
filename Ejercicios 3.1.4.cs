using System;
class Ejercicios_314
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.1.4.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.1.4.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3141(); break;
				case 2: Ejercicio_3142(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el
formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el
resultado obtenido por el programa.*/
	static void Ejercicio_3141()
	{
		int x=15, y=-10, z=214;
		x*=12;
		y*=12;
		z*=12;
		Console.WriteLine("x ahora vale {0}, y ahora vale {1} y z ahora vale {2}",x,y,z);
		Console.WriteLine();
	}
	/*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3;
c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.*/
	static void Ejercicio_3142()
	{
		int a=5, b=a+2, c=-3;
		Console.WriteLine("b=a+2 es {0}",b);
		b-=3;
		Console.WriteLine("b-=3 es {0}",b);
		c*=2;
		Console.WriteLine("c*=2 es {0}",c);
		++c;
		Console.WriteLine("++c es {0}",c);
		a*=b;
		Console.WriteLine("a*=b es {0}",a);
		Console.WriteLine();
	}
}
