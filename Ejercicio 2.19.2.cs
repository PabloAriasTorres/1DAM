/*Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
carácter, usando "switch" (pista: necesitarás que usar un dato de tipo "char").*/
using System;
class Ejercicio_2192
{
	static void Main()
	{
		char letra;
		Console.WriteLine("Introduce una letra:");
		letra=Convert.ToChar(Console.ReadLine());
		switch(letra)
		{
			case '.':Console.WriteLine("Punto"); break;
			case ':':Console.WriteLine("Dos puntos"); break;
			case ',':Console.WriteLine("Coma"); break;
			case ';':Console.WriteLine("Punto y coma"); break;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':Console.WriteLine("Número"); break;
			case ' ':Console.WriteLine("Espacio"); break;
			default:Console.WriteLine("Ni espacio ni signo de puntuación ni ningún número"); break;
		}
	}
}
