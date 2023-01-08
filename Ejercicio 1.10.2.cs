class Ejercicio_1102
{
	static void Main()
	{
		int numero1, numero2, dividir=0, resto=0;
		System.Console.WriteLine("Introduce el primer número");
		numero1=System.Convert.ToInt32( System.Console.ReadLine());
		System.Console.WriteLine("Introduce el segundo número");
		numero2=System.Convert.ToInt32( System.Console.ReadLine());
		dividir=numero1/numero2;
		resto=numero1%numero2;
		System.Console.WriteLine("El resultado es {0} y el resto es {1}",dividir,resto);
	}
}
