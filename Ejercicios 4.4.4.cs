using System;
class Ejercicios_444
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.4.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.4.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.4.4.3");
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
				case 1: Ejercicio_4441(); break;
				case 2: Ejercicio_4442(); break;
				case 3: Ejercicio_4443(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio, similar al 4.4.3.1, pero esta vez usando
"Substring". Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u
a n"*/
	static void Ejercicio_4441()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		for( int i=0; i<nombre.Length; i++)
		{
			Console.Write("{0} ",nombre.Substring(i,1));
		}
	}
	/*Un programa que te pida tu nombre y lo muestre en pantalla como un
triángulo creciente. Por ejemplo, si tu nombre es "Juan", debería aparecer en
pantalla:*/
	static void Ejercicio_4442()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		for( int i=0; i<nombre.Length; i++)
		{
			Console.WriteLine("{0}",nombre.Substring(0,i+1));
		}
	}
	/*Un programa que te pida tu nombre y lo muestre en pantalla como un
triángulo creciente desde la derecha. Por ejemplo, si tu nombre es "Juan", debería
aparecer en pantalla:*/
	static void Ejercicio_4443()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		for( int i=0; i<nombre.Length; i++)
		{
			for( int j=0; j<nombre.Length-(i+1);j++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("{0}",nombre.Substring(0,i+1));
		}
	}
}
