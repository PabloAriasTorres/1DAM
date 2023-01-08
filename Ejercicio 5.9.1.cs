/*Crea una función que calcule el valor de elevar un número entero a otro
número entero (por ejemplo, 5 elevado a 3 = 53
= 5 ·5 ·5 = 125). Esta función se debe crear de forma recursiva. Piensa cuál será el caso base (qué potencia se
puede calcular de forma trivial) y cómo pasar del caso "n-1" al caso "n" (por ejemplo, si sabes el valor de 54 , cómo hallarías el de 55 a partir de él).*/
using System;
class Ejercicio_591
{
	static int Potencia( int num1, int num2)
	{
		if(num2==0) return 1;
		if(num2==1) return num1;
		num2--;
		return num1*Potencia(num1,num2);
	}
	
	static void Main()
	{
		int num1=0, num2=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce la base:");
				num1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce la potencia:");
				num2=Convert.ToInt32(Console.ReadLine());
				if(num2<0) throw new Exception("No puede ser un número negativo el exponente");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		Potencia(num1,num2);
		Console.WriteLine("La potencia es {0}",Potencia(num1,num2));
	}
}

