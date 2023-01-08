/*Crea un programa que encuentre el máximo común divisor de dos
números usando el algoritmo de Euclides: Dados dos números enteros positivos m
y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor
entero positivo que divide a ambos, se puede: 1) Dividir m por n para obtener el
resto r (0 ≤ r < n) ; 2) Si r = 0, el MCD es n; 3) Si el resto no es cero, el máximo
común divisor es MCD(n,r).*/
using System;
class Ejercicio_598
{
	static int MCD(int num1, int num2)
	{
		if(num1%num2==0) return num2;
		return MCD(num2,num1%num2);
	}
	
	static void Main()
	{
		int num1=0, num2=0;
		bool ok=false;
		
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num1=Convert.ToInt32(Console.ReadLine());
				if(num1<=1) throw new Exception("Para hacer el MCD el número tiene que ser mayor que uno");
				Console.WriteLine("Introduce otro número:");
				num2=Convert.ToInt32(Console.ReadLine());
				if(num2<=1) throw new Exception("Para hacer el MCD el número tiene que ser mayor que uno");
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
		Console.WriteLine("El MCD es {0}",MCD(num1,num2));
	}
}
