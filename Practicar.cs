using System;
class Practicar1
{
	static void Main()
	{
		string larga="", corta="", resultado="";
		int pos_nueva=0, pos_actual=0;
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Escribe una frase larga");
				larga = Console.ReadLine();
				if(larga=="") throw new Exception("La cadena no puede estar vacía");
				if(larga.Length<10) throw new Exception("Mínimo tiene que tener 10 caracteres");
				Console.WriteLine("Escribre una palabra para buscar");
				corta = Console.ReadLine();
				if(corta=="") throw new Exception("La cadena no puede estar vacía");
				ok=true;
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		
		while(pos_nueva>=0)
		{
			pos_nueva = larga.ToLower().IndexOf(corta.ToLower(),pos_actual);
			if(pos_nueva >=0)
			{
				pos_actual = pos_nueva + 1;
				if(resultado=="") resultado += pos_nueva;
				else resultado = resultado + ',' + pos_nueva;
			}
		}
		if(resultado=="") Console.WriteLine("No se ha encontrado nada");
		else Console.WriteLine("La palabra {0} se ha encontrado en la/las posición/posiciones {1}",corta,resultado);
	}
}
