/*Crea, tanto de forma recursiva como de forma iterativa, una función diga si
una cadena de caracteres es simétrica (un palíndromo). Por ejemplo, "OSO",
"RADAR" y "DABALEARROZALAZORRAELABAD" son palíndromos.*/
using System;

class Ejercicio_597
{
	static bool Palindromo(string cadena, int i, int j)
	{
		if(i==j) return true;
		if(cadena.ToLower()[i]==cadena.ToLower()[j]) return Palindromo(cadena,++i,--j);
		return false;
	}
	
	static void Main()
	{
		string cadena="";
		int i=0;
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		int j=cadena.Length - 1;
		if(Palindromo(cadena,i,j)==true) Console.WriteLine("Si es un palíndromo");
		else Console.WriteLine("No es un palíndromo");
	}
}

/*class Ejercicio_Sin_Recursividad 
{
	static void Main()
	{
		string cadena="a", dupla="";
		char[] guardar;
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		guardar=new char[cadena.Length];
		
		for(int i=0, j=cadena.Length - 1; i<cadena.Length; i++, j--)
		{
			guardar[i]=cadena[j];
		}
		for( int i=0; i<guardar.Length; i++)
		{
			dupla+=guardar[i];
		}
		Console.Write("La cadena invertida es ");
		for(int i=0; i<guardar.Length;i++)
		{
			Console.Write("{0}",guardar[i]);
		}
		Console.WriteLine();
		if(cadena.ToLower()==dupla.ToLower()) Console.WriteLine("Si es un palíndromo");
	}
}*/
