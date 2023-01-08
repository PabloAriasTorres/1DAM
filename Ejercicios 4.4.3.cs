using System;
class Ejercicios_443
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.3.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.3.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.4.3.3");
				Console.WriteLine("Escribe 4 para el ejercicio 4.4.3.4");
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
				case 1: Ejercicio_4431(); break;
				case 2: Ejercicio_4432(); break;
				case 3: Ejercicio_4433(); break;
				case 4: Ejercicio_4434(); break;
			}
		}
		while(entrar==false);
	}
	/*) Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan",
debería aparecer en pantalla "J u a n".*/
	static void Ejercicio_4431()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		for( int i=0; i<nombre.Length; i++)
		{
			Console.Write("{0} ",nombre[i]);
		}
	}
	/*Un programa que pida una frase al usuario y la muestre en orden inverso
(de la última letra a la primera)*/
	static void Ejercicio_4432()
	{
		string frase="a";
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		Console.WriteLine("La longitud de {0} es {1}",frase,frase.Length);
		
		for( int i=frase.Length-1; i>=0; i--)
		{
			Console.Write("{0}",frase[i]);
		}
	}
	/*Un programa que pida al usuario una frase, después una letra y
finalmente diga si aparece esa letra como parte de esa frase o no.*/
	static void Ejercicio_4433()
	{
		string frase="a";
		char letra='a';
		bool encontrar=false;
		
		Console.WriteLine("Introduce una frase:");
		frase=Console.ReadLine();
		Console.WriteLine("Introduce una letra:");
		letra=Convert.ToChar(Console.ReadLine());
		
		for( int i=0; i<frase.Length; i++)
		{
			if(letra==frase[i])
			{
				Console.WriteLine("Si aparece la letra en la frase");
				encontrar=true;
				break;
			}
		}
		if(encontrar==false)
		{
			Console.WriteLine("No aparece la letra en la frase");
		}
	}
	/*Un programa capaz de sumar dos números enteros muy grandes (por
ejemplo, de 50 cifras), que se deberán pedir como cadena de texto y analizar letra
a letra (pista: tendrás que pensar cómo sumas dos números a mano: qué ocurre si
al suma cifra a cifra obtienes un número mayor que 10 y cómo tratar el caso de
que los dos números no tengan la misma longitud).*/
	static void Ejercicio_4434()
	{
		string num1="a", num2="a";
		int mayor, menor, total=0;
		
		Console.WriteLine("Introduce un número:");
		num1=Console.ReadLine();
		Console.WriteLine("Introduce otro número:");
		num2=Console.ReadLine();
		
		int[] numeros1 = new int[num1.Length];
		
		for( int i=0; i<numeros1.Length; i++)
		{
			numeros1[i]=Convert.ToInt32(numeros1[i].ToString());
		}
		
		int[] numeros2 = new int[num2.Length];
		
		for( int i=0; i<numeros2.Length; i++)
		{
			numeros2[i]=Convert.ToInt32(numeros2[i].ToString());
		}
		
		if(numeros1.Length==numeros2.Length)
		{
			mayor=numeros1.Length;
			menor=numeros2.Length;
			Console.WriteLine("Los dos son igual de largos");
		}
		else
		{
			if(numeros1.Length>numeros2.Length)
			{
				mayor=numeros1.Length;
				menor=numeros2.Length;
				Console.WriteLine("{0} es el más largo",num1);
			}
			else
			{
				mayor=numeros2.Length;
				menor=numeros1.Length;
				Console.WriteLine("{0} es el más largo",num2);
			}
		}
		for( int i=mayor-1; i>0; i--)
		{
			int j=menor-1;
			int suma;
			int mesobra=0;;
			suma=i+j;
			
			if(suma >= 10)
			{
				suma-=10;
				total= total + suma;
				mesobra++;
			}
			else
			{
				total= total + suma;
			}
			total= total + mesobra;
			mesobra=0;
			suma=0;
			j--;
		}
		Console.WriteLine("El resultado de sumar {0}+{1} es {2}",num1,num2,total);
	}
}
