using System;
class Ejercicios_441
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
				Console.WriteLine("Escribe 1 para el ejercicio 4.4.1.1");
				Console.WriteLine("Escribe 2 para el ejercicio 4.4.1.2");
				Console.WriteLine("Escribe 3 para el ejercicio 4.4.1.3");
				Console.WriteLine("Escribe 4 para el ejercicio 4.4.1.4");
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
				case 1: Ejercicio_4411(); break;
				case 2: Ejercicio_4412(); break;
				case 3: Ejercicio_4413(); break;
				case 4: Ejercicio_4414(); break;
			}
		}
		while(entrar==false);
	}
	/* Crea un programa que te pida tu nombre y lo escriba 5 veces.*/
	static void Ejercicio_4411()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		
		for( int i=0;i<5;i++)
		{
			Console.Write("{0} ",nombre);
		}
	}
	/*Crea un programa que pida al usuario su nombre. Si se llama como tú
(por ejemplo, "Nacho"), responderá "Bienvenido, jefe". En caso contrario, le
saludará por su nombre.*/
	static void Ejercicio_4412()
	{
		string nombre="a";
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		if(nombre=="Pablo") Console.WriteLine("Bienvenido crack!");
		else Console.WriteLine("Macaco {0} detectado",nombre);
	}
	/*Un programa que pida tu nombre, tu día de nacimiento y tu mes de
nacimiento y lo junte todo en una cadena, separando el nombre de la fecha por
una coma, y el día y el mes por una barra inclinada, así: "Juan, nacido el 31/12".*/
	static void Ejercicio_4413()
	{
		string nombre="a", resultado;
		int dia=0, mes=0;
		
		Console.WriteLine("Introduce tu nombre:");
		nombre=Console.ReadLine();
		Console.WriteLine("Introduce tu día de nacimiento:");
		dia=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce tu mes de nacimiento:");
		mes=Convert.ToInt32(Console.ReadLine());
		resultado= nombre + ", nacido el " + dia+"/"+mes + ".";
		Console.WriteLine(resultado);
	}
	/*Crea un programa que pida al usuario dos números enteros y después
una operación que realizar con ellos. La operación podrá ser "suma", "resta",
multiplicación" y "división", que también se podrán escribir de forma abreviado
con los operadores matemáticos "+", "-", "*" y "/". Para multiplicar también se
podrá usar una "x", minúscula o mayúscula. A continuación se mostrará el
resultado de esa operación (por ejemplo, si los números son 3 y 6 y la operación es
"suma", el resultado sería 9). La operación debes tomarla como una cadena de
texto y analizarla con un "switch"*/
	static void Ejercicio_4414()
	{
		int n=0, num1=0, num2=0, total;
		string resultado;
		
		Console.WriteLine("Introduce un número:");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce otro número:");
		num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Pulsa 1 para suma, Pulsa 2 para resta, Pulsa 3 para multiplicar o Pulsa 4 para dividir");
		Console.WriteLine();
		Console.WriteLine("Introduce un número para la operación que quieras:");
		n=Convert.ToInt32(Console.ReadLine());
		
		switch(n)
		{
			case 0: break;
			case 1:
				total=num1+num2;
				resultado= "El resultado de sumar "+ num1 + "+" + num2 + "=" + total;
				Console.WriteLine(resultado);
				break;
			case 2:
				total=num1-num2;
				resultado= "El resultado de restar "+ num1 + "-" + num2 + "=" + total;
				Console.WriteLine(resultado);
				break;
			case 3:
				total=num1*num2;
				resultado= "El resultado de multiplicar "+ num1 + "x" + num2 + "=" + total;
				Console.WriteLine(resultado);
				break;
			case 4:
				total=num1/num2;
				resultado= "El resultado de dividir "+ num1 + "/" + num2 + "=" + total;
				Console.WriteLine(resultado);
				break;
		}
	}
}
