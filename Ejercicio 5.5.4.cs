/* Crea una función "ContarLetra", que reciba una cadena y una letra, y
devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo, si
la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a" aparece
2 veces).*/
using System;
class Ejercicio_554
{
	static int ContarLetra(string cadena, char letra)
	{
		int contador=0;
		
		for( int i=0; i<cadena.Length;i++)
		{
			if(letra==cadena[i]) contador++;
		}
		return(contador);
	}
	
	static void Main()
	{
		string cadena="a";
		char letra='a';
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		Console.WriteLine("Introduce una letra:");
		letra=Convert.ToChar(Console.ReadLine());
		ContarLetra(cadena,letra);
		Console.WriteLine("La letra se ha repetido {0} veces",ContarLetra(cadena,letra));
	}
}
