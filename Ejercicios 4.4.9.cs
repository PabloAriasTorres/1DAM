using System;
using System.Text;
class Ejercicios_449
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.9.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.9.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.4.9.3");
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
				case 1: Ejercicio_4491(); break;
				case 2: Ejercicio_4492(); break;
				case 3: Ejercicio_4493(); break;
			}
		}
		while(entrar==false);
	}
	/*Prepara un programa que pida una cadena al usuario y la modifique, de
modo que todas las vocales se conviertan en "o".*/
	static void Ejercicio_4491()
	{
		string cadena="a";
		
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		
		StringBuilder cadenaModificable = new StringBuilder(cadena);
		
		for( int i=0; i<cadenaModificable.Length; i++)
		{
			if(cadenaModificable[i]=='a' || cadenaModificable[i]=='e' || cadenaModificable[i]=='i' || cadenaModificable[i]=='u')
			{
				cadenaModificable[i]='o';
			}
			if(cadenaModificable[i]=='A' || cadenaModificable[i]=='E' || cadenaModificable[i]=='I' || cadenaModificable[i]=='U')
			{
				cadenaModificable[i]='O';
			}
		}
		Console.WriteLine("Tu cadena modificada a quedado así: {0}",cadenaModificable);
	}
	/*Un programa que pida una cadena al usuario y la modifique, de modo
que las letras de las posiciones impares (primera, tercera, etc.) estén en
minúsculas y las de las posiciones pares estén en mayúsculas, mostrando el
resultado en pantalla. Por ejemplo, a partir de un nombre como "Nacho", la
cadena resultante sería "nAcHo".*/
	static void Ejercicio_4492()
	{
		string cadena="a";
		Console.WriteLine("Introduce una cadena:");
		cadena=Console.ReadLine();
		
		StringBuilder cadenaModificable = new StringBuilder(cadena);
		
		for( int i=0; i<cadenaModificable.Length; i++)
		{
			if(i%2==0)
			{
				cadenaModificable[i]=Convert.ToChar(cadenaModificable[i].ToString().ToLower());
			}
			else
			{
				cadenaModificable[i]=Convert.ToChar(cadenaModificable[i].ToString().ToUpper());
			}
		}
		Console.WriteLine("Tu cadena ha quedado así: {0}",cadenaModificable);
	}
	/*Crea un juego del ahorcado, en el que un primer usuario introduzca la
palabra a adivinar, se muestre ésta oculta con guiones (-----) y el programa acepte
las letras que introduzca el segundo usuario, cambiando los guiones por letras
correctas cada vez que acierte (por ejemplo, a---a-t-). La partida terminará cuando
se acierte la palabra por completo o el usuario agote sus 8 intentos.*/
	static void Ejercicio_4493()
	{
		string pal_secreta="a";
		char letra='a';
		int vidas=8, posicion=0;
		
		Console.WriteLine("Introduce una palabra:");
		pal_secreta=Console.ReadLine();
		
		StringBuilder pal_guiones = new StringBuilder(new string('-',pal_secreta.Length));
		Console.WriteLine("{0}",pal_guiones);
		
		while(vidas!=0)
		{
			Console.WriteLine("Introduce una letra:");
			letra=Convert.ToChar(Console.ReadLine());
			if((posicion=pal_secreta.IndexOf(letra.ToString()))>=0)
			{
				pal_guiones[posicion]=letra;
			}
			else
			{
				vidas--;
			}
			Console.WriteLine("{0}",pal_guiones);
			Console.WriteLine();
			if(vidas==0)
			{
				Console.WriteLine("Te has quedado sin vidas");
			}
		}
	}
}
