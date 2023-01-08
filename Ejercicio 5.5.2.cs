/*) Crea una función "EscribirTablaMultiplicar", que reciba como parámetro un
número entero, y escriba la tabla de multiplicar de ese número (por ejemplo, para
el 3 deberá llegar desde "3x0=0" hasta "3x10=30").*/
using System;
class Ejercicio_552
{
	static void EscribirTablaMultiplicar(int num)
	{
		for( int i=0; i<11; i++)
		{
			int total=0;
			total=num*i;
			Console.WriteLine("{0}x{1}={2}",num,i,total);
		}
	}
	
	static void Main()
	{
		int num=0;
		Console.WriteLine("Introduce un número para la tabla de multiplicar:");
		num=Convert.ToInt32(Console.ReadLine());
		EscribirTablaMultiplicar(num);
	}
}
