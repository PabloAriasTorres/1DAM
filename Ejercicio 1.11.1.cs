using System; /* Con esto no hará falta poner System. ya que estamos utilizando una librería */
class Ejercicio_1111
{
	static void Main()
	{
		int numero1, numero2, total=0;
		Console.WriteLine("Introduce el primer número");
		numero1=Convert.ToInt32( Console.ReadLine());
		Console.WriteLine("Introduce el segundo número");
		numero2=Convert.ToInt32( Console.ReadLine());
		total=numero1*numero2;
		Console.WriteLine("El resultado es {0}",total);
	}
}
