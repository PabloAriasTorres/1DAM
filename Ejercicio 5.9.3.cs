/*Crea un programa que emplee recursividad para calcular un número de la
serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes,
cada elemento es la suma de los dos anteriores).*/
using System;
class Ejercicio_593
{
	static int Fibonacci(int pos, int[] numeros)
	{
		numeros[0]=1;
		numeros[1]=1;
		numeros[pos]=numeros[pos-1] + numeros[pos-2];
		if(pos==numeros.Length-1) return numeros[pos];
		return Fibonacci(++pos,numeros);
	}
	
	static void Main()
	{
		int pos=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el número de Fibonacci que quieras:");
				pos=Convert.ToInt32(Console.ReadLine());
				if(pos<=0) throw new Exception("Error: tiene que ser mayor que uno");
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
		int[] numeros = new int[pos];
		Console.WriteLine("El número que has pedido es {0}",Fibonacci(2,numeros));
	}
}
