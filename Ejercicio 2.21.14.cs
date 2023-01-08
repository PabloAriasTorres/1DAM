using System;
class Ejercicio_22114
{
	static void Main()
	{
		int n1, n2, multiplo1, multiplo2;
		Console.WriteLine("Introduce un número (0 para salir):");
		n1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número (0 para salir):");
		n2=Convert.ToInt32(Console.ReadLine());
		while((n1!=0)&&(n2!=0))
		{
			multiplo1= n1 % n2;
			multiplo2= n2 % n1;
			if((multiplo1==0)||(multiplo2==0))
			{
				Console.WriteLine("Son múltiplos");
			}
			else
			{
				Console.WriteLine("No son múltiplos");
			}
			Console.WriteLine("Introduce un número (0 para salir):");
			n1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Introduce otro número (0 para salir):");
			n2=Convert.ToInt32(Console.ReadLine());
			
		}
	}
}
