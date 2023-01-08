using System;
class Ejercicios_448
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.8.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.8.2");
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
				case 1: Ejercicio_4481(); break;
				case 2: Ejercicio_4482(); break;
			}
		}
		while(entrar==false);
	}
	/*Un programa que pida al usuario dos frases y diga cuál sería la "mayor"
de ellas (la que aparecería en último lugar en un diccionario).*/
	static void Ejercicio_4481()
	{
		string frase1="a", frase2="a";
		
		Console.WriteLine("Introduce una frase:");
		frase1=Console.ReadLine();
		Console.WriteLine("Introduce otra frase:");
		frase2=Console.ReadLine();
		
		if(frase1==frase2) Console.WriteLine("Son la misma frase");
		else
		{
			if(frase1.ToLower().CompareTo(frase2.ToLower())>0)
			{
				Console.WriteLine("La mayor es {0}",frase1);
			}
			else
			{
				Console.WriteLine("La mayor es {0}",frase2);
			}
		}
	}
	/* Un programa que pida al usuario cinco frases, las guarde en un array y
muestre la "mayor" de ellas.*/
	static void Ejercicio_4482()
	{
		string[] frases = new string[5];
		string mayor;
		
		for( int i=0; i<frases.Length; i++)
		{
			Console.WriteLine("Introduce una frase:");
			frases[i]=Console.ReadLine();
		}
		mayor=frases[0];
		for( int i=0; i<frases.Length;i++)
		{
			if(frases[i].ToLower().CompareTo(mayor.ToLower())>0) mayor=frases[i];
		}
		Console.WriteLine("La \"mayor\" de todas es {0}",mayor);
	}
}
