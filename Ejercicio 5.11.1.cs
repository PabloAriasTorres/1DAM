/*Crea una función "DibujarRecuadro", que muestre en pantalla un recuadro
del ancho y alto que indique el usuario, y relleno con el carácter que también se
indique como tercer parámetro. El carácter será opcional, y se usarán
"almohadillas" si no se indicar otro distinto. El alto también será opcional, con un
valor por defecto de 3. Prúebalo desde Main.*/
using System;
class Ejercicio_5111
{
	static int DibujarRecuadro(int alto, int ancho, char caracter)
	{
		for(int i=0; i<alto; i++)
		{
			for(int j=0; j<ancho; j++)
			{
				Console.Write("{0}",caracter);
			}
			Console.WriteLine();
		}
		return alto;
	}
	
	static void Main()
	{
		int alto=0, ancho=0;
		char caracter='a';
		Console.WriteLine("Introduce el alto( 0 si no quieres introducirlo)");
		alto=Convert.ToInt32(Console.ReadLine());
		if(alto==0) alto=3;
		Console.WriteLine("Introduce el ancho:");
		ancho=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce un cáracter( / si no quieres introducirlo)");
		caracter=Convert.ToChar(Console.ReadLine());
		if(caracter=='/') caracter='*';
		Console.WriteLine(DibujarRecuadro(alto,ancho,caracter));
	}
}
