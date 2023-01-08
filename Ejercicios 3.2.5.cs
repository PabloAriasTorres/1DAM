using System;
class Ejercicios_325
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 3.2.5.1");
			Console.WriteLine("Escribe 2 para el ejercicio 3.2.5.2");
			Console.WriteLine("Escribe 3 para el ejercicio 3.2.5.3");
			Console.WriteLine("Escribe 4 para el ejercicio 3.2.5.4");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_3251(); break;
				case 2: Ejercicio_3252(); break;
				case 3: Ejercicio_3253(); break;
				case 4: Ejercicio_3254(); break;
			}
		}
		while(entrar==false);
	}
	/*El usuario de nuestro programa podrá teclear dos números de hasta 12
cifras significativas. El programa deberá mostrar el resultado de dividir el primer
número entre el segundo, utilizando tres cifras decimales.*/
	static void Ejercicio_3251()
	{
		double num1=0, num2=0, dividir;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num1=Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Introduce otro número:");
				num2=Convert.ToDouble(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		dividir=num1/num2;
		Console.WriteLine( dividir.ToString("N3") );
	}
	/*Crea un programa que use tres variables x,y,z. Las tres serán números
reales, y nos bastará con datos de simple precisión. Se deberá pedir al usuario los
valores para las tres variables y mostrar en pantalla el valor de x2
+ y - z (con exactamente dos cifras decimales).*/
	static void Ejercicio_3252()
	{
		float x=0, y=0, z=0, resultado;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el valor de x:");
				x=float.Parse(Console.ReadLine());
				Console.WriteLine("Introduce el valor de y:");
				y=float.Parse(Console.ReadLine());
				Console.WriteLine("Introduce el valor de z:");
				z=float.Parse(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);
		resultado=(float)Math.Pow(x,2)+y-z;
		Console.Write("El resultado es ");
		Console.Write( resultado.ToString("N2") );
		Console.WriteLine();
	}
	/*Calcula el perímetro, área y diagonal de un rectángulo, a partir de su
ancho y alto (perímetro = suma de los cuatro lados; área = base x altura; diagonal
= hipotenusa, usando el teorema de Pitágoras). Muestra todos ellos con una cifra
decimal*/
	static void Ejercicio_3253()
	{
		float ancho=0, alto=0, perimetro, area, diagonal;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el alto del rectángulo:");
				alto=float.Parse(Console.ReadLine());
				Console.WriteLine("Introduce el ancho del rectángulo:");
				ancho=float.Parse(Console.ReadLine());
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
		}
		while(ok==false);	
		perimetro=alto+alto+ancho+ancho;
		area=ancho*alto;
		diagonal=(float)Math.Sqrt(alto*alto+ancho*ancho);
		Console.Write("El perímetro es ");
		Console.Write( perimetro.ToString("N1") );
		Console.WriteLine();
		Console.Write("El área es ");
		Console.Write( area.ToString("N1") );
		Console.WriteLine();
		Console.Write("La diagonal es ");
		Console.Write( diagonal.ToString("N1") );
		Console.WriteLine();
	}
	/*Calcula la superficie y el volumen de una esfera, a partir de su radio
(superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). Usa
datos "doble" y muestra los resultados con 5 cifras decimales.*/
	static void Ejercicio_3254()
	{
		double superficie, volumen, radio=0;
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
		superficie=4*Math.PI*(radio*radio);
		volumen=4/3*Math.PI*(radio*radio*radio);
		Console.Write("La superficie es de ");
		Console.Write( superficie.ToString("N5"));
		Console.WriteLine();
		Console.Write("El volumen es de ");
		Console.Write( volumen.ToString("N5"));
		Console.WriteLine();
	}
}

