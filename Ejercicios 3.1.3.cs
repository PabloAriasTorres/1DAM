using System;
class Ejercicios_313
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.1.3.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.1.3.2");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3131(); break;
				case 2: Ejercicio_3132(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que use tres variables enteras x,y,z. Sus valores
iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas
variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado
obtenido por el programa.*/
	static void Ejercicio_3131()
	{
		int x=15, y=-10;
		int z=2147483647;
		x++;
		y++;
		z++;
		Console.WriteLine("x ahora vale {0}",x);
		Console.WriteLine("y ahora vale {0}",y);
		Console.WriteLine("z ahora vale {0}",z);
		Console.WriteLine();
	}
	/*¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++;
b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para
ver si habías hallado la solución correcta.*/
	static void Ejercicio_3132()
	{
		int a=5, b=0, c=0;
		b=++a;
		Console.WriteLine("b=++a es {0}",b);
		c=a++;
		Console.WriteLine("c=a++ es {0}",c);
		b=b*5;
		Console.WriteLine("b=b*5 es {0}",b);
		a=a*2;
		Console.WriteLine("a=a*2 es {0}",a);
		Console.WriteLine();
	}
}
