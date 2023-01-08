using System;
class Ejercicio_2159
{
	static void Main()
	{
		int n1, n2, n3;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce otro número");
		n2=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce un tercer número");
		n3=Convert.ToInt32( Console.ReadLine());
		if((n1>n2)&&(n1>n3))
		{
			Console.WriteLine("{0} es el mayor",n1);
		}
		if((n2>n1)&&(n2>n3))
		{
			Console.WriteLine("{0} es el mayor",n2);
		}
		if((n3>n1)&&(n3>n2))
		{
			Console.WriteLine("{0} es el mayor",n3);
		}
	}
}
