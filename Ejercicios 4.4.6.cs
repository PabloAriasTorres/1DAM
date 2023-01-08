using System;
class Ejercicios_446
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.6.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.6.2");
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
				case 1: Ejercicio_4461(); break;
				case 2: Ejercicio_4462(); break;
			}
		}
		while(entrar==false);
	}
	/*Una variante del ejercicio 4.4.5.1 (buscar textos en un array de frases),
que no distinga entre mayúsculas y minúsculas a la hora de buscar.*/
	static void Ejercicio_4461()
	{
		string[] frases= new string[10];
		string texto="a";
		
		for( int i=0;i<frases.Length; i++)
		{
			Console.WriteLine("Introduce una frase:");
			frases[i]=Console.ReadLine();
			frases[i]=frases[i].ToLower();
		}
		Console.WriteLine();
		for( int i=0; i<frases.Length;i++)
		{
			Console.WriteLine("Introduce algún texto( fin para acabar)");
			texto=Console.ReadLine();
			texto=texto.ToLower();
			if(texto=="fin") break;
			if(frases[i].IndexOf(texto)>=0)
			{
				Console.WriteLine("{0} aparece dentro de {1} en la posición {2}",texto,frases[i],frases[i].IndexOf(texto));
			}
			else
			{
				Console.WriteLine("No ha aparecido");
			}
		}
	}
	/*Un programa que pida al usuario una frase y elimine todos los espacios
redundantes que contenga (debe quedar sólo un espacio entre cada palabra y la
siguiente).*/
	static void Ejercicio_4462()
	{
		string frase="a";
		char espacio=' ';
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		
		for( int i=0; i<frase.Length; i++)
		{
			if(espacio==frase[i])
			{
				Console.Write("{0}",frase.Replace(" ",""));
				break;
			}
		}
	}
}
