using System;
class Ejercicio_1121
{
	static void Main()
	{
		int n1, n2, total1, total2;
		Console.WriteLine("Introduce el primer número");
		n1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce el segundo número");
		n2=Convert.ToInt32( Console.ReadLine());
		total1=(n1+n2)*(n1-n2);
		total2=(n1*n1)-(n2*n2);
		Console.WriteLine("El resultado de({0}+{1})*({2}-{3}) es {4} y el resultado de {5}*{6}-{7}*{8} es {9}",n1,n2,n1,n2,total1,n1,n1,n2,n2,total2);
	}
}
