using System;
class examenbucle
{
	static void Main()
	{
		string opcion="";
		do
		{
			Console.WriteLine();
			Console.WriteLine("Pulsa 0 para salir");
			Console.WriteLine("Pulsa 1 para");
			Console.WriteLine("Pulsa 2 para");
			Console.WriteLine("Pulsa 3 para");
			opcion = Console.ReadLine();
			switch(opcion)
			{
				case "0": break;
				case "1": Console.WriteLine("Hola"); break;
				case "2": Console.WriteLine("Adiós"); break;
				case "3": Console.WriteLine(opcion); break;
			}
		}
		while(opcion!="0");
	}
}
