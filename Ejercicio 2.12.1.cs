using System;
class Ejercicio_2121
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Introduce un número");
		n1=Convert.ToInt32( Console.ReadLine());
		if(10%n1==0)
		{
			Console.WriteLine("{0} es múltiplo de 10",n1);
			Console.WriteLine("Introduce otro número");
			n2=Convert.ToInt32( Console.ReadLine());
			if(10%n2==0)
			{
				Console.WriteLine("{0} es múltiplo de 10",n2);
			}
			else
			{
				Console.WriteLine("{0} no es múltiplo de 10",n2);
			}	
	    }
	    else
		{
			Console.WriteLine("{0} no es múltiplo de 10",n1);
		}
	}
}
