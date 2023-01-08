using System;
class Ejercicios_447
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.7.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.7.2");
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
				case 1: Ejercicio_4471(); break;
				case 2: Ejercicio_4472(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario una frase y muestre sus palabras en
orden inverso.*/
	static void Ejercicio_4471()
	{
		string frase="a";
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		
		string[] fraseInversa= frase.Split();
		
		for( int i=fraseInversa.Length-1; i>=0; i--)
		{
			Console.Write("{0} ",fraseInversa[i]);
		}
	}
	/*Un programa que pida al usuario varios números separados por espacios
y muestre su suma*/
	static void Ejercicio_4472()
	{
		int num1=0, num2=0, num3=0, total;
		
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce el último número:");
		num3=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("{0} {1} {2}",num1,num2,num3);
		total=num1+num2+num3;
		Console.WriteLine("El total es {0}",total);
	}
}
