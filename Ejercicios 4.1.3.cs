using System;
class Ejercicios_413
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 4.1.3.1");
			Console.WriteLine("Escribe 2 para el ejercicio 4.1.3.2");
			Console.WriteLine("Escribe 3 para el ejercicio 4.1.3.3");
			Console.WriteLine("Escribe 4 para el ejercicio 4.1.3.4");
			Console.WriteLine("Escribe 5 para el ejercicio 4.1.3.5");
			Console.WriteLine("Escribe 6 para el ejercicio 4.1.3.6");
			Console.WriteLine("Escribe 7 para el ejercicio 4.1.3.7");
			Console.WriteLine("Escribe 8 para el ejercicio 4.1.3.8");
			Console.WriteLine("Escribe 9 para el ejercicio 4.1.3.9");
			Console.WriteLine("Escribe 10 para el ejercicio 4.1.3.10");
			Console.WriteLine("Escribe 11 para el ejercicio 4.1.3.11");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_4131(); break;
				case 2: Ejercicio_4132(); break;
				case 3: Ejercicio_4133(); break;
				case 4: Ejercicio_4134(); break;
				case 5: Ejercicio_4135(); break;
				case 6: Ejercicio_4136(); break;
				case 7: Ejercicio_4137(); break;
				case 8: Ejercicio_4138(); break;
				case 9: Ejercicio_4139(); break;
				case 10: Ejercicio_41310(); break;
				case 11: Ejercicio_41311(); break;
			}
		}
		while(entrar==false);
	}
	/*Crea un programa que pida al usuario 6 números enteros cortos y luego
los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para
mostrarlos).*/
	static void Ejercicio_4131()
	{
		int[] numeros= new int[6];
		
		for( int i=0; i<6; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		Console.WriteLine("{0} {1} {2} {3} {4} {5}",numeros[5],numeros[4],numeros[3],numeros[2],numeros[1],numeros[0]);
	}
	/*) Crea un programa que pregunte al usuario cuántos números enteros va a
introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y
finalmente calcule y muestre la media de esos números.*/
	static void Ejercicio_4132()
	{
		int j, suma=0, total;
		
		Console.WriteLine("Introduce la cantidad de números:");
		j=Convert.ToInt32(Console.ReadLine());
		
		int[] numeros= new int[j];
		
		for( int i=0; i<j; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			suma=suma+numeros[i];
		}
		total=suma/j;
		Console.WriteLine("La media es {0}",total);
	}
	/* Un programa que pida al usuario 10 reales de doble precisión, calcule su
media y luego muestre los que están por encima de la media.*/
	static void Ejercicio_4133()
	{
		double[] numeros= new double[10];
		double suma=0, total;
		
		for( int i=0; i<10; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToDouble(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
			suma=suma+numeros[i];	
		}
		total=suma/10;
		for( int i=0; i<10; i++)
		{
			if(numeros[i]>total)
			{
				Console.WriteLine("{0}  ",numeros[i]);
			}
		}
		Console.WriteLine();
	}
	/* Un programa que almacene en una tabla el número de días que tiene
cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para
febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año (por
ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día
365).*/
	static void Ejercicio_4134()
	{
		int[] dias= {31,28,31,30,31,30,31,31,30,31,30,31};
		int mes=0, dia=0, total=0;
		bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce el número del mes que quieras (ej. 3 para Marzo)");
					mes=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce el número del día que quieras:");
					dia=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		for( int i=1; i<mes; i++)
		{
			total=total+dias[i];
		}
		total=total+dia;
		Console.WriteLine("El día es {0}",total);
		Console.WriteLine();
	}
	/*) A partir del ejercicio anterior, crea otro que pida al usuario que le indique
la fecha, formada por día (1 al 31) y el mes (1=enero, 12=diciembre), y como
respuesta muestre en pantalla el número de días que quedan hasta final de año.*/
	static void Ejercicio_4135()
	{
		int[] dias= {31,28,31,30,31,30,31,31,30,31,30,31};
		int mes=0, dia=0, total=0;
		bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce el mes:");
					mes=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce el día:");
					dia=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		for( int i=1; i<mes; i++)
		{
			total=total+dias[i];
		}
		total=365-(total+dia);
		Console.WriteLine("Quedan {0} días para fin de año",total);
		Console.WriteLine();
	}
	/* Un programa que pida 10 nombres y los memorice (pista: esta vez se
trata de un array de "string"). Después deberá pedir que se teclee un nombre y
dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir
otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se
teclee "fin". En el siguiente apartado verás detalles de cómo hacer ese tipo de
búsquedas.*/
	static void Ejercicio_4136()
	{
		string[] nombres= {"Pepe","Juan","Alberto","Pablo","Pedro","Dani","Fernando","Alejandro","Andrea","Antonio"};
		string nombre="a";
		bool acabar=false;
		
		while(acabar==false)
		{
			Console.WriteLine("Introduce un nombre (fin para acabar):");
			nombre=Console.ReadLine();
			if(nombre=="fin")
			{
				acabar=true;
			}
			for( int i=0; i<10; i++)
			{
				if(nombre==nombres[i])
				{
					Console.WriteLine("El nombre introducido ha sido encontrado");
					Console.WriteLine();
					break;
				}
			}
		}
	}
	/* Un programa que prepare espacio para guardar un máximo de 100
nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se
pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres
y se mostrará en pantalla la lista de los nombres que se han introducido.*/
	static void Ejercicio_4137()
	{
		string[] nombres= new string[100];
		int cantidad=0;
		
			for( int i=0; i<100; i++)
			{
				Console.WriteLine("Introduce un nombre(Intro para acabar):");
				nombres[i]=Console.ReadLine();
				Console.WriteLine();
				cantidad++;
				if(nombres[i]=="h") break;
			}
			for( int i=0; i<cantidad; i++)
			{
				Console.WriteLine("{0} ",nombres[i]);
			}
	}
	/* Un programa que reserve espacio para un vector de 3 componentes, pida
al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su
módulo (la raíz cuadrada de la suma de sus componentes al cuadrado; por
ejemplo, para [2, -5, 7] el resultado sería la raíz cuadrada de 78, aproximadamente
8,83).*/
	static void Ejercicio_4138()
	{
		float[] numeros= new float[3];
		float total;
		
		for( int i=0; i<3; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=float.Parse(Console.ReadLine());
					ok=true;
				}
				catch
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		total=(float)Math.Sqrt(numeros[0]*numeros[0]+numeros[1]*numeros[1]+numeros[2]*numeros[2]);
		Console.WriteLine("El módulo es {0}", total);
		Console.WriteLine();
	}
	/*Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule la suma de ambos vectores (su primera
componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
	static void Ejercicio_4139()
	{
		int[] numeros1= new int[3];
		int[] numeros2= new int[3];
		int total1, total2, total3;
		
		for( int i=0; i<3; i++)
		{
			Console.WriteLine("Introduce un número para el primer vector:");
			numeros1[i]=Convert.ToInt32(Console.ReadLine());
		}
		for( int i=0; i<3; i++)
		{
			Console.WriteLine("Introduce un número para el segundo vector:");
			numeros2[i]=Convert.ToInt32(Console.ReadLine());
		}
		total1=numeros1[0]+numeros2[0];
		total2=numeros1[1]+numeros2[1];
		total3=numeros1[2]+numeros2[2];
		Console.WriteLine("El resultado es ({0},{1},{2})",total1,total2,total3);
		Console.WriteLine();
	}
	/*Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2 + z1·z2).*/
	static void Ejercicio_41310()
	{
		int[] numeros1= new int[3];
		int[] numeros2= new int[3];
		int total1, total2, total3, total_final;
		
		for( int i=0; i<3; i++)
		{
			Console.WriteLine("Introduce un número para el primer vector:");
			numeros1[i]=Convert.ToInt32(Console.ReadLine());
		}
		for( int i=0; i<3; i++)
		{
			Console.WriteLine("Introduce un número para el segundo vector:");
			numeros2[i]=Convert.ToInt32(Console.ReadLine());
		}
		total1=numeros1[0]*numeros2[0];
		total2=numeros1[1]*numeros2[1];
		total3=numeros1[2]*numeros2[2];
		total_final=total1+total2+total3;
		Console.WriteLine("El resultado es {0}",total_final);
		Console.WriteLine();
	}
	/*Un programa que pida al usuario 4 números enteros y calcule (y
muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array,
hay que comparar cada uno de los valores que tiene almacenados el array con el
que hasta ese momento es el máximo provisional. El valor inicial de este máximo
provisional no debería ser cero (porque el resultado sería incorrecto si todos los
números son negativos), sino el primer elemento del array. Si no lo consigues, en
el próximo apartado tienes más detalles sobre cómo resolver este problema.*/
	static void Ejercicio_41311()
	{
		int[] numeros= new int[4];
		int mayor;
		
		for( int i=0; i<4; i++)
		{
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un número:");
					numeros[i]=Convert.ToInt32(Console.ReadLine());
					ok=true;
				}
				catch
				{
					Console.WriteLine("Error: no es un valor válido");
				}
			}
			while(ok==false);
		}
		mayor=numeros[0];
		for( int i=0; i<4; i++)
		{
			if(numeros[i]>mayor) mayor=numeros[i];
		}
		Console.WriteLine("El mayor de todos es {0}", mayor);
		Console.WriteLine();
	}
}
