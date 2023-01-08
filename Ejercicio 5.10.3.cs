/* Crea una variante del ejercicio 5.10.2, en la que Main devuelva el código 1
si la operación indicada no es válida o 0 cuando sí sea una operación aceptable.*/
using System;
class Ejercicio_5103
{
	static void Main(string[] args)
	{
		args = new string[2];
		
		for(int i=0; i<args.Length;i++)
		{
			Console.WriteLine("Introduce un número:");
			args[i]=Console.ReadLine();
		}
		Console.WriteLine();
		int n=10;
		while(n!=0)
		{
			Console.WriteLine("Pulsa 0 para acabar");
			Console.WriteLine("Pulsa 1 para sumar");
			Console.WriteLine("Pulsa 2 para restar");
			Console.WriteLine("Pulsa 3 para multiplicar");
			Console.WriteLine("Pulsa 4 para dividir");
			n=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			switch(n)
			{
				case 0: break;
				case 1:
					int suma;
					suma=Convert.ToInt32(args[0])+Convert.ToInt32(args[1]);
					Console.WriteLine("La suma es {0}",suma);
					Console.WriteLine();
					break;
				case 2:
					int resta;
					resta=Convert.ToInt32(args[0])-Convert.ToInt32(args[1]);
					Console.WriteLine("La resta es {0}",resta);
					Console.WriteLine();
					break;
				case 3:
					int multiplicar;
					multiplicar=Convert.ToInt32(args[0])*Convert.ToInt32(args[1]);
					Console.WriteLine("La multiplicación es {0}",multiplicar);
					Console.WriteLine();
					break;
				case 4:
					int dividir;
					dividir=Convert.ToInt32(args[0])/Convert.ToInt32(args[1]);
					Console.WriteLine("La división es {0}",dividir);
					Console.WriteLine();
					break;
			}
		}
	}
}
