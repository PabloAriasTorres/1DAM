class Ejercicio_1103
{
	static void Main()
	{
		int numero1, numero2, numero3, total=0;
		System.Console.WriteLine("Introduce el primer número");
		numero1=System.Convert.ToInt32( System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo número");
		numero2=System.Convert.ToInt32( System.Console.ReadLine());
		System.Console.WriteLine("Introduce el tercer número");
		numero3=System.Convert.ToInt32( System.Console.ReadLine());
		total=numero1+numero2+numero3;
		System.Console.WriteLine("El resultado es {0}",total);
	}
}
