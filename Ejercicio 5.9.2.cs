/*Como alternativa, crea una función que calcule el valor de elevar un
número entero a otro número entero de forma NO recursiva (lo que llamaremos
"de forma iterativa"), usando la orden "for"*/
using System;
class Ejercicio_592
{
	static int Potencia(int num1, int num2)
	{
		int total=num1;
	
		while(num2!=1)
		{
			total=total*num1;
			num2--;
		}
		return total;
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
