/*) Crea un programa llamado "suma", que calcule (y muestre) la suma de dos
números que se le indiquen como parámetros en línea de comandos. Por ejemplo,
* si se teclea "suma 2 3" deberá responder "5", si se teclea "suma 2" responderá "2"
y si se teclea únicamente "suma" deberá responder "No hay suficientes datos" y
devolver un código de error 1.*/
using System;
class Ejercicio_5101
{
	static int Main(string[] args)
	{
		args= new string[2];
		int suma;
		
		for(int i=0; i<args.Length;i++)
		{
			Console.WriteLine("Introduce un número(a para terminar):");
			args[i]=Console.ReadLine();
			if(args[i]=="a") break;
		}
		if(args.Length==2)
		{	suma = Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]);
			Console.WriteLine("La suma es {0}",suma);
		}
		if(args.Length==0)
		{
			Console.WriteLine("No se ha introducido ningún dato");
			return 1;
		}
		else
		{
			return 0;
		}
		
	}
}
