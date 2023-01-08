class Ejercicio_1104
{
	static void Main()
	{
		float metros;
		float millas;
		System.Console.WriteLine("Introduce un número de millas náuticas");
		millas=System.Convert.ToInt32( System.Console.ReadLine());
		metros=millas*1852;
		System.Console.WriteLine("El resultado es {0}", metros);
	}
}
