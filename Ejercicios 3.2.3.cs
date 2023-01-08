using System;
class Ejercicios_323
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.3.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.3.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.2.3.3");
			Console.WriteLine("Escribe 4 para el ejercicio 3.2.3.4");
			Console.WriteLine("Escribe 5 para el ejercicio 3.2.3.5");
			Console.WriteLine("Escribe 6 para el ejercicio 3.2.3.6");
			Console.WriteLine("Escribe 7 para el ejercicio 3.2.3.7");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3231(); break;
				case 2: Ejercicio_3232(); break;
				case 3: Ejercicio_3233(); break;
				case 4: Ejercicio_3234(); break;
				case 5: Ejercicio_3235(); break;
				case 6: Ejercicio_3236(); break;
				case 7: Ejercicio_3237(); break;
			}
		}
		while(entrar==false);
	}
	/*Calcula el volumen de una esfera, dado su radio, que será un número de
doble precisión (volumen = pi * radio al cubo * 4/3)*/
	static void Ejercicio_3231()
	{
		double radio=0, volumen;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el radio de la esfera:");
				radio=Convert.ToDouble(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		volumen=Math.PI*(radio*radio*radio)*4/3;
		Console.WriteLine("El volumen de la esfera es {0}",volumen);
		Console.WriteLine();
	}
	/*Crea un programa que pida al usuario a una distancia (en metros) y el
tiempo necesario para recorrerla (como tres números: horas, minutos, segundos),
y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas
por hora (pista: 1 milla = 1.609 metros).*/
	static void Ejercicio_3232()
	{
		int minuto=0, distancia=0, hora=0, millas=0, segundo=0, tiempo_total1, tiempo_total2;
		float velocidad1, velocidad2, velocidad3;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una distancia en metros:");
				distancia=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el tiempo necesario (en horas) para recorrerla:");
				hora=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el tiempo necesario (en minutos) para recorrerla:");
				minuto=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el tiempo necesario (en segundos) para recorrerla:");
				segundo=Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		tiempo_total1=segundo+(hora*3600)+(minuto*60);
		tiempo_total2=hora+(minuto/60)+(segundo/3600);
		millas=1609/distancia;
		velocidad1=(float)distancia/tiempo_total1;
		velocidad2=(float)distancia/tiempo_total2;
		velocidad3=(float)millas/tiempo_total2;
		Console.WriteLine("{0}m/s",velocidad1);
		Console.WriteLine("{0}km/h",velocidad2);
		Console.WriteLine("{0}milla/h",velocidad3);
		Console.WriteLine();
	}
	/*Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2+
Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)*/
	static void Ejercicio_3233()
	{
		double a=0, b=0, c=0, x_suma, x_resta;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el primer número:");
				a=Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Introduce el segundo número:");
				b=Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Introduce el tercer número:");
				c=Convert.ToDouble(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		x_suma=(-b+Math.Sqrt((b*b)-4*a*c))/2*a;
		x_resta=(-b-Math.Sqrt((b*b)-4*a*c))/2*a;
		Console.WriteLine("El resultado positivo es {0}",x_suma);
		Console.WriteLine("El resultado negativo es {0}",x_resta);
		Console.WriteLine();
	}
	/*Si se ingresan E euros en el banco a un cierto interés I durante N años, el
dinero obtenido viene dado por la fórmula del interés compuesto: Resultado = e
(1+ i)n Aplícalo para calcular en cuanto se convierten 1.000 euros al cabo de 10
años al 3% de interés anual.*/
	static void Ejercicio_3234()
	{
		double E=1000, I=3, N=10, resultado;
		resultado=E*Math.Pow(1+I,N);
		Console.WriteLine("El resultado es {0}",resultado);
		Console.WriteLine();
	}
	/*Crea un programa que muestre los primeros 20 valores de la función y =x2-1*/
	static void Ejercicio_3235()
	{
		double y, x=1, contador=1;
		while(contador<=20)
		{
			y=Math.Pow(x,2)-1;
			contador++;
			x++;
			Console.WriteLine("El resultado es {0}",y);
		}
		Console.WriteLine();
	}
	/*) Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x
entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y luego un
asterisco. La cantidad de espacios dependerá del valor obtenido para "y". Te será
fácil si dibujas la gráfica "girada", de forma que los valores de "y" crezcan hacia la
derecha, así:*/
		static void Ejercicio_3236()
		{
			int y, x=1;
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un valor para x que esté entre 1 y el 10:");
					x=Convert.ToInt32(Console.ReadLine());
					if(x<1 || x>10) throw new Exception("x tiene que ser mayor que 1 y menor que 10");
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
				catch(Exception e)
				{
					Console.WriteLine("Error: {0}",e.Message);
				}
			}
			while(ok==false);
			if(x>=1 && x<=10)
			{
				y=(int)Math.Pow(x-5,2);
				for(x; x<=10; x++)
				{
					for(y; y<=x;y++)
					{
						Console.Write("*");
				    }
				    Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("Error: x tiene que ser mayor que 1 y menor que 10");
				Console.WriteLine();
			}
	    }
	    /*Escribe un programa que calcule una aproximación de PI mediante la
expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... El usuario deberá
indicar la cantidad de términos a utilizar, y el programa mostrará todos los
resultados hasta esa cantidad de términos. Debes hacer todas las operaciones con
"double".*/
		static void Ejercicio_3237()
		{
			double pi, contador=1, num=0, salir_while=0, contador2=3, total=0;
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
				total=pi+total;
				contador+=4;
				contador2+=4;
				salir_while++;
			}
			total=4*total;
			Console.WriteLine("El resultado es {0}",total);
		}
}
