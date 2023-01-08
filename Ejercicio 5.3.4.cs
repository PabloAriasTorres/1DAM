/* Crea una función "EscribirRepetido", que reciba un carácter y un número, y
escriba ese carácter tantas veces como indique ese número (todas ellas en la
misma línea).*/
using System;
class Ejercicio_534
{
	static void EscribirRepetido()
	{
		int num=0;
		char letra='a';
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce un número:");
				num=Convert.ToInt32(Console.ReadLine());
				if(num<1) throw new Exception("Error: el número tiene que ser mayor que 1");
				Console.WriteLine("Introduce un carácter:");
				letra=Convert.ToChar(Console.ReadLine());
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
			for( int i=0; i<num; i++)
			{
				Console.Write("{0} ",letra);
			}
		}
		while(ok==false);
	}
	
	static void Main()
	{
		EscribirRepetido();
	}
}
