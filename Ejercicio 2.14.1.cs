using System;
class Ejercicio_2141
{
	static void Main()
	{
		int n1, n2, producto;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		if(n1==0)
		{
			Console.WriteLine("El producto de 0 por cualquier número es 0");
		}
		else
		{
			Console.WriteLine("Introduce otro número");
			n2=Convert.ToInt32( Console.ReadLine());
			producto=n1*n2;
			Console.WriteLine("El producto de {0} y {1} es igual a {2}",n1,n2,producto);
		}
	}
}
