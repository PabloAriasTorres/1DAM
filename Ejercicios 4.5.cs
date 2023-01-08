using System;
class Ejercicios_45
{
	static void Main()
	{
		int n=0;
		bool entrar=false;
		
		do
		{
			try
			{
				Console.WriteLine("Escribe 0 para salir");
				Console.WriteLine("Escribe 1 para el ejercicio 4.5.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.5.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.5.3");
				Console.WriteLine();
				Console.WriteLine("Introduce el número del ejercicio:");
				n=Convert.ToInt32(Console.ReadLine());
				entrar=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
				Console.WriteLine();
			}
		
			switch(n)
			{
				case 0: break;
				case 1: Ejercicio_451(); break;
				case 2: Ejercicio_452(); break;
				case 3: Ejercicio_453(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida tu nombre y lo muestre con un espacio entre cada
par de letras, usando "foreach"*/
	static void Ejercicio_451()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		foreach( char letras in nombre)
		{
			Console.Write("{0} ",letras);
		}
	}
	/*Un programa que pida al usuario una frase y la descomponga en
subcadenas separadas por espacios, usando "Split". Luego debe mostrar cada
subcadena en una línea nueva, usando "foreach".*/
	static void Ejercicio_452()
	{
		string frase;
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		
		string[] frasePartida = frase.Split('-');
		
		foreach(string subcadena in frasePartida)
		{
			Console.WriteLine(subcadena);
		}
	}
	/*Un programa que pida al usuario varios números separados por espacios y
muestre su suma (como el del ejercicio 4.4.7.2), empleando "foreach".*/
	static void Ejercicio_453()
	{
		int[] numeros = new int[3];
		int total=0;
		
		for( int i=0; i<numeros.Length; i++)
		{
			Console.WriteLine("Introduce un número:");
			numeros[i]=Convert.ToInt32(Console.ReadLine());
			total=total+numeros[i];
			foreach(int n in numeros)
			{
				Console.Write("{0} ",n);
			}
			Console.WriteLine();
		}
		Console.WriteLine("El total es {0}",total);
	}
}
