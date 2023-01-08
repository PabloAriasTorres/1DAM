using System;
class Ejercicios_414
{
	static void Main()
	{
		int n;
		bool entrar=false;
		do
		{
			Console.WriteLine("Escribe 0 para salir");
			Console.WriteLine("Escribe 1 para el ejercicio 4.1.4.1");
			Console.WriteLine("Escribe 2 para el ejercicio 4.1.4.2");
			Console.WriteLine("Escribe 3 para el ejercicio 4.1.4.3");
			Console.WriteLine("Escribe 4 para el ejercicio 4.1.4.4");
			Console.WriteLine("Escribe 5 para el ejercicio 4.1.4.5");
			Console.WriteLine();
			Console.WriteLine("Introduce el número del ejercicio:");
			n=Convert.ToInt32(Console.ReadLine());
			switch(n)
			{
				case 0: entrar=true; break;
				case 1: Ejercicio_4141(); break;
				case 2: Ejercicio_4142(); break;
				case 3: Ejercicio_4143(); break;
				case 4: Ejercicio_4144(); break;
				case 5: Ejercicio_4145(); break;
			}
		}
		while(entrar==false);
	}
	/* Crea una variante del ejemplo 04_01_04a que pida al usuario el dato a
buscar, avise si ese dato no aparece, y que diga cuántas veces se ha encontrado en
caso contrario.*/
	static void Ejercicio_4141()
	{
		int[] numeros={20,5,3,7,1,8,4,0,20,32,20};
		int cantidad=10, num=0, contador=0;
		
		Console.WriteLine("Introduce el número a buscar:");
		num=Convert.ToInt32(Console.ReadLine());
		for( int i=0; i<cantidad; i++)
		{
			if(numeros[i]==num)
			{
				 Console.WriteLine("{0} encontrado en la posición {1}",num,i+1);
				 Console.WriteLine();
				 contador++;
			}
		}
		if(contador==0) Console.WriteLine("{0} no ha sido encontrado",num);
		
	}
	/*) Crea una variante del ejemplo 04_01_04a que añada un dato introducido
por el usuario al final de los datos existentes.*/
	static void Ejercicio_4142()
	{
		int[] numeros={20,5,3,7,1,8,4,0,20,32,20};
		int cantidad=10, num=0, capacidad=11;
		
		Console.WriteLine("Introduce un número al final:");
		num=Convert.ToInt32(Console.ReadLine());
		if(cantidad<capacidad)
		{
			numeros[cantidad]=num;
			cantidad++;
		}
		for( int i=0; i<cantidad; i++)
		{
			Console.Write("{0} ",numeros[i]);
		}
		Console.WriteLine();
	}
	/*Crea una variante del ejemplo 04_01_04a que inserte un dato introducido
por el usuario en la posición que elija el usuario. Debe avisar si la posición
escogida es incorrecta (porque esté más allá del final de los datos).*/
	static void Ejercicio_4143()
	{
		int[] numeros={20,5,3,7,1,8,4,20,20,32,0};
		int cantidad=10, num=0, capacidad=11, posicion=0;
		
		Console.WriteLine("Introduce el número a insertar:");
		num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce la posición para insertar el número:");
		posicion=Convert.ToInt32(Console.ReadLine());
		
		if(cantidad<posicion) Console.WriteLine("Error: no se puede insertar un número en una posición inexistente");
		
		if(cantidad<capacidad)
		{
			for( int i=cantidad; i>posicion; i--)
			{
				numeros[i]=numeros[i-1];
				numeros[posicion]=num;
				cantidad++;
			}
		}
		for( int i=0; i<cantidad; i++)
		{
			Console.Write("{0} ",numeros[i]);
		}
	}
	/*Crea una variante del ejemplo 04_01_04a que borre el dato que se
encuentre en la posición que escoja el usuario. Debe avisar si la posición
seleccionada no es válida.*/
	static void Ejercicio_4144()
	{
		int[] numeros={20,5,3,7,1,8,4,20,20,32,0};
		int cantidad=10, num=0, capacidad=11, posicion=0;
		
		Console.WriteLine("Introduce el número a borrar:");
		num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce la posición para borrar el número:");
		posicion=Convert.ToInt32(Console.ReadLine());
		
		if(cantidad<posicion) Console.WriteLine("Error: no se puede insertar un número en una posición inexistente");
		
		if(cantidad<capacidad)
		{
			for( int i=posicion; i<cantidad-1; i++)
			{
				numeros[i]=numeros[i+1];
				cantidad--;
			}
		}
		for( int i=0; i<cantidad; i++)
		{
			Console.Write("{0} ",numeros[i]);
		}
		Console.WriteLine();
	}
	/*Crea un programa que prepare espacio para un máximo de 10 nombres.
Deberá mostrar al usuario un menú que le permita realizar las siguientes
operaciones: */
	static void Ejercicio_4145()
	{
		string[] nombres= new string[10];
		int capacidad=10, cantidad=0, n=0, posicion_Insertar=0, posicion_Borrar=0;
		string nombre="a";
		
		Console.WriteLine("Pulsa 0 para acabar");
		Console.WriteLine("Pulsa 1 para añadir un dato al final");
		Console.WriteLine("Pulsa 2 para insertar un dato");
		Console.WriteLine("Pulsa 3 para borrar un dato");
		
		Console.WriteLine();
		
		Console.WriteLine("Introduce el número del apartado que quieras:");
		n=Convert.ToInt32(Console.ReadLine());
		
			switch(n)
			{
				case 0: break;
				case 1: 
					for(int i=0; i<10; i++)
					{
						Console.WriteLine("Introduce un máximo de 10 nombres (PEPE para dejar de poner nombres):");
						nombres[i]=Console.ReadLine();
						if(nombres[i]=="PEPE")
						{
							nombres[i]=nombres[i-1];
							break;
						}
						cantidad++;
					}
					Console.WriteLine("Introduce un nombre adicional al final:");
					nombre=Console.ReadLine();
					if(cantidad<capacidad)
					{
						nombres[cantidad]=nombre;
						cantidad++;
					}
					for(int i=0; i<cantidad;i++)
					{
						Console.Write("{0} ",nombres[i]);
					}
					Console.WriteLine();
					break;
				case 2:
					for(int i=0; i<10; i++)
					{
						Console.WriteLine("Introduce un máximo de 10 nombres (PEPE para dejar de poner nombres):");
						nombres[i]=Console.ReadLine();
						if(nombres[i]=="PEPE")
						{
							nombres[i]=nombres[i-1];
							break;
						}
						cantidad++;
					}
					Console.WriteLine("Introduce el nombre a insertar:");
					nombre=Console.ReadLine();
					Console.WriteLine("Introduce la posición para insertar dicho nombre:");
					posicion_Insertar=Convert.ToInt32(Console.ReadLine());
					if(cantidad<capacidad)
					{
						for( int i=cantidad; i>posicion_Insertar; i--)
						{
							nombres[i]=nombres[i-1];
							nombres[posicion_Insertar-1]=nombre;
						}
						cantidad++;
					}
					for(int i=0; i<cantidad;i++)
					{
						Console.Write("{0} ",nombres[i]);
					}
					Console.WriteLine();
					break;
				case 3:
					for(int i=0; i<10; i++)
					{
						Console.WriteLine("Introduce un máximo de 10 nombres (PEPE para dejar de poner nombres):");
						nombres[i]=Console.ReadLine();
						if(nombres[i]=="PEPE")
						{
							nombres[i]=nombres[i-1];
							break;
						}
						cantidad++;
					}
					Console.WriteLine("Introduce la posición para borrar el dato:");
					posicion_Borrar=Convert.ToInt32(Console.ReadLine());
					for( int i=posicion_Borrar-1; i<cantidad-1;i++)
					{
						nombres[i]=nombres[i+1];
					}
					cantidad--;
					for(int i=0; i<cantidad;i++)
					{
						Console.Write("{0} ",nombres[i]);
					}
					Console.WriteLine();
					break;	
			}
	}
}
