using System;
class Ejercicio_2193
{
	static void Main()
	{
		char letra;
		Console.WriteLine("Introduce una letra:");
		letra=Convert.ToChar(Console.ReadLine());
		switch(letra)
		{
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
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':Console.WriteLine("Vocal"); break;
			case 'q':
			case 'w':
			case 'r':
			case 't':
			case 'y':
			case 'p':
			case 's':
			case 'd':
			case 'f':
			case 'g':
			case 'h':
			case 'j':
			case 'k':
			case 'l':
			case 'ñ':
			case 'z':
			case 'x':
			case 'c':
			case 'v':
			case 'b':
			case 'n':
			case 'm':Console.WriteLine("Consonante"); break;
		}
	}
}
