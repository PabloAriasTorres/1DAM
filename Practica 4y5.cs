using System;
class Ejercicio_practica
{
	struct caracAlum
	{
		public string dni;
		public string nombre;
		public string apellidos;
		public string ciudad;
		public fechaNac fecha;
		public notaTot notas;
	}
	struct fechaNac
	{
		public int dia;
		public int mes;
		public int anyo;
	}
	struct notaTot
	{
		public float nota1;
		public float nota2;
		public float nota3;
		public float notafinal;
	}
	
	static void Main()
	{
		int contadorAlu=0, caso=0, pos_borrar=0, crit_orden=0;
		bool ok=false;
		caracAlum[] alumnos = new caracAlum[100];
		do
		{
			try
			{
				Console.WriteLine("Pulsa 0 para cerrar");
				Console.WriteLine("Pulsa 1 para añadir un alumno");
				Console.WriteLine("Pulsa 2 para borrar un alumno");
				Console.WriteLine("Pulsa 3 para ordenar los alumnos");
				Console.WriteLine("Pulsa 4 para buscar un alumno");
				Console.WriteLine();
				Console.WriteLine("Introduce el caso que quieras");
				caso=Convert.ToInt32(Console.ReadLine());
				if(caso<0 || caso>4) throw new Exception("Solo hay casos del 0 al 5");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
				switch(caso)
				{
					case 0: ok=true; break;
					case 1:
						Pedir_caracAlum( alumnos, ref contadorAlu);
						Pedir_fechaNac( alumnos, ref contadorAlu);
						Pedir_notasTot( alumnos, ref contadorAlu);
						MostrarDatos( alumnos, ref contadorAlu);
						AnyadirAlumno(alumnos, ref contadorAlu);
						ok=false;
						break;
					case 2:
						BorrarAlumno(alumnos, ref contadorAlu, pos_borrar);
						ok=false;
						break;
					case 3:
						OrdenarAlumno(alumnos, ref contadorAlu, crit_orden);
						ok=false;
						break;
					case 4:
						BuscarAlumnos(alumnos, ref contadorAlu);
						ok=false;
						break;
				}
		}
		while(ok==false);
	}
	
	static void Pedir_caracAlum( caracAlum[] alumnos, ref int contadorAlu)
	{
		string guardarNombre="";
		/*string num_dni="";
		char letra_dni='a';*/
		bool ok=false;
		
		do
		{
			try
			{
				Console.WriteLine("Introduce tu dni:");
				alumnos[contadorAlu].dni=Console.ReadLine();
				if(alumnos[contadorAlu].dni=="") throw new Exception("El campo no puede estar vacío");
				if(alumnos[contadorAlu].dni.Length!=9) throw new Exception("Un DNI tiene 8 números y una letra");
				// He intentado hacer un buen control de errores para el DNI pero no he sabido hacerlo bien
				/*for(int i=0; i<8; i++)
				{
					num_dni=num_dni + alumnos[contadorAlu].dni[i];
				}
				letra_dni=alumnos[contadorAlu].dni[8];
				if(Convert.ToInt32(num_dni)!=0 || Convert.ToString(letra_dni)=="") throw new Exception("Los primeros ocho caracteres son números y el último es una letra");*/
					
				Console.WriteLine("Introduce tu nombre y apellidos:");
				guardarNombre=Console.ReadLine();
				if(guardarNombre=="") throw new Exception("El campo no puede estar vacío");
				if(guardarNombre.IndexOf(" ",0,guardarNombre.Length)<=0) throw new Exception("Debes poner tus apellidos");
					
				Console.WriteLine("Introduce tu ciudad:");
				alumnos[contadorAlu].ciudad=Console.ReadLine();
				if(alumnos[contadorAlu].ciudad=="") throw new Exception("El campo no puede estar vacío");
					
				ok=true;
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		string[] separar_nombre_apellidos = guardarNombre.Split(' ');
		if(separar_nombre_apellidos.Length==2)
		{
			alumnos[contadorAlu].nombre=separar_nombre_apellidos[0];
			alumnos[contadorAlu].apellidos=separar_nombre_apellidos[1];
		}
		else
		{
			alumnos[contadorAlu].nombre=separar_nombre_apellidos[0];
			alumnos[contadorAlu].apellidos=separar_nombre_apellidos[1] + " " + separar_nombre_apellidos[2];
		}
	}
	
	static void Pedir_fechaNac( caracAlum[] alumnos, ref int contadorAlu)
	{
		bool ok=false;
		string guardarFecha="";
		
		do
		{
			try
			{
				Console.WriteLine("Introduce tu fecha de nacimiento con este formato dd-mm-aaaa por ejemplo: 21-04-2004:");
				guardarFecha=Console.ReadLine();
				if(guardarFecha.Length!=10) throw new Exception("Se debe cumplir con el formato especificado");
				string fecha_dia=Convert.ToString(guardarFecha[0]) + Convert.ToString(guardarFecha[1]);
				string fecha_mes=Convert.ToString(guardarFecha[3]) + Convert.ToString(guardarFecha[4]);
				string fecha_anyo=Convert.ToString(guardarFecha[6]) + Convert.ToString(guardarFecha[7]) + Convert.ToString(guardarFecha[8]) + Convert.ToString(guardarFecha[9]);
				if(Convert.ToInt32(fecha_dia)<1 || Convert.ToInt32(fecha_dia)>31) throw new Exception("Los meses tienen como máximo 31 días");
				if(Convert.ToInt32(fecha_mes)<1 || Convert.ToInt32(fecha_mes)>12) throw new Exception("Los meses van del 1(enero) hasta 12(diciembre)");
				if(Convert.ToInt32(fecha_anyo)<1900 || Convert.ToInt32(fecha_anyo)>2022) throw new Exception("El año mínimo es 1900 y como máximo 2022");
				ok=true;
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		string[] separar_dia_mes_anyo = guardarFecha.Split('-');
		alumnos[contadorAlu].fecha.dia = Convert.ToInt32(separar_dia_mes_anyo[0]);
		alumnos[contadorAlu].fecha.mes = Convert.ToInt32(separar_dia_mes_anyo[1]);
		alumnos[contadorAlu].fecha.anyo = Convert.ToInt32(separar_dia_mes_anyo[2]);
	}
	
	static void Pedir_notasTot( caracAlum[] alumnos, ref int contadorAlu)
	{
		bool ok=false;
		
		do
		{
			try
			{
				Console.WriteLine("Introduce la nota de la primera evaluación:");
				alumnos[contadorAlu].notas.nota1=float.Parse(Console.ReadLine());
				if(alumnos[contadorAlu].notas.nota1<0 || alumnos[contadorAlu].notas.nota1>10) throw new Exception("Las notas van de 0 hasta 10");
				Console.WriteLine("Introduce la nota de la segunda evaluación:");
				alumnos[contadorAlu].notas.nota2=float.Parse(Console.ReadLine());
				if(alumnos[contadorAlu].notas.nota2<0 || alumnos[contadorAlu].notas.nota2>10) throw new Exception("Las notas van de 0 hasta 10");
				Console.WriteLine("Introduce la nota de la tercera evaluación:");
				alumnos[contadorAlu].notas.nota3=float.Parse(Console.ReadLine());
				if(alumnos[contadorAlu].notas.nota3<0 || alumnos[contadorAlu].notas.nota3>10) throw new Exception("Las notas van de 0 hasta 10");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		
		alumnos[contadorAlu].notas.notafinal=(alumnos[contadorAlu].notas.nota1 + alumnos[contadorAlu].notas.nota2 + alumnos[contadorAlu].notas.nota3)/3;
	}
	
	static void MostrarDatos( caracAlum[] alumnos, ref int contadorAlu)
	{
		
		Console.WriteLine();
		Console.WriteLine("El DNI del alumno es {0}",alumnos[contadorAlu].dni.ToUpper());
		Console.WriteLine("El nombre del alumno es {0}",alumnos[contadorAlu].nombre);
		Console.WriteLine("Los apellidos del alumno son {0}",alumnos[contadorAlu].apellidos);
		Console.WriteLine("La ciudad en la que nació el alumno es {0}",alumnos[contadorAlu].ciudad);
		Console.WriteLine("El dia en el que nació el alumno es {0}",alumnos[contadorAlu].fecha.dia);
		Console.WriteLine("El mes en el que nació el alumno es {0}",alumnos[contadorAlu].fecha.mes);
		Console.WriteLine("El año en el que nació el alumno es {0}",alumnos[contadorAlu].fecha.anyo);
		Console.WriteLine("La nota de la primera evaluación es {0}",alumnos[contadorAlu].notas.nota1);
		Console.WriteLine("La nota de la segunda evaluación es {0}",alumnos[contadorAlu].notas.nota2);
		Console.WriteLine("La nota de la tercera evaluación es {0}",alumnos[contadorAlu].notas.nota3);
		Console.WriteLine("La nota final es {0}",alumnos[contadorAlu].notas.notafinal);
		Console.WriteLine();
			
	}
	
	static void AnyadirAlumno(caracAlum[] alumnos, ref int contadorAlu)
	{
		int contador=0;
		for(int k=0; k<alumnos.Length; k++)
		{
			if(contadorAlu==k) break;
			if(alumnos[contadorAlu].dni==alumnos[k].dni)
			{
				contador++;
			}
		}
		
		if(contador==0)
		{
			contadorAlu++;
		}
		else 			/*Volver a pedir el DNI y que vuelva a esta funcion*/
		{
			Console.WriteLine("No se puede registrar alumnos diferentes con el mismo DNI");
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce tu dni de nuevo:");
					alumnos[contadorAlu].dni=Console.ReadLine();
					if(alumnos[contadorAlu].dni=="") throw new Exception("El campo no puede estar vacío");
					if(alumnos[contadorAlu].dni.Length!=9) throw new Exception("Un DNI tiene 8 números y una letra");
					ok=true;
				}
				catch(Exception e)
				{
					Console.WriteLine("{0}",e.Message);
				}
			}
			while(ok==false);
			AnyadirAlumno(alumnos, ref contadorAlu);
		}
	}
	
	static void BorrarAlumno(caracAlum[] alumnos, ref int contadorAlu, int pos_borrar)
	{
		if(contadorAlu==0)
		{
			Console.WriteLine();
			Console.WriteLine("Debes introducir algún alumno antes de borrarlo");
			Console.WriteLine();
			Main();
		}
		else
		{
			MostrarAlumnos(alumnos, ref contadorAlu);
			bool ok=false;
			do
			{
				try
				{
					Console.WriteLine("Introduce un alumno a borrar:");
					pos_borrar=Convert.ToInt32(Console.ReadLine());
					if(pos_borrar>contadorAlu) throw new Exception("No se puede borrar un espacio vacío");
					if(pos_borrar<=0) throw new Exception("No existen posiciones negativas");
					if(Convert.ToString(pos_borrar)=="") throw new Exception("Debes introducir la posición");
					ok=true;
				}
				catch(FormatException)
				{
					Console.WriteLine("Error: no es un valor válido");
				}
				catch(Exception e)
				{
					Console.WriteLine("{0}",e.Message);
				}
			}
			while(ok==false);
			if(BorrarAuxAlumno(alumnos, ref contadorAlu, pos_borrar)==true)
			{
				Console.WriteLine();
				Console.WriteLine("El alumno ha sido borrado correctamente");
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("El alumno no se ha podido borrar");
			}
			Console.WriteLine();
		}
	}
	
	static bool BorrarAuxAlumno(caracAlum[] alumnos, ref int contadorAlu, int pos_borrar)
	{
		int comprobar=contadorAlu;
		/*No hace falta verificar la posición a borrar en esta función ya que en la función BorrarAlumno hay un control de errores para que la posición a borrar
		  sea válida*/
		for(int i=0; i<contadorAlu; i++)
		{
			alumnos[pos_borrar-1]=alumnos[pos_borrar];
		}
		contadorAlu--;
		if(comprobar==contadorAlu+1) return true;
		else return false;
	}
	
	static void OrdenarAlumno(caracAlum[] alumnos, ref int contadorAlu, int crit_orden)
	{
		MostrarAlumnos(alumnos, ref contadorAlu);
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Pulsa 1 para ordenar por apellidos(ascendente)");
				Console.WriteLine("Pulsa 2 para ordenar por DNI(ascendente)");
				Console.WriteLine("Pulsa 3 para ordenar por cuidad(descendente)");
				Console.WriteLine();
				Console.WriteLine("Introduce el criterio de ordenación");
				crit_orden=Convert.ToInt32(Console.ReadLine());
				if(crit_orden<1 || crit_orden>3) throw new Exception("Solo hay 3 posible casos");
				if(Convert.ToString(crit_orden)=="") throw new Exception("El campo no puede estar vacío");
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
			
			switch(crit_orden)
			{
				case 1:
					OrdenarAuxAlumno(alumnos, ref contadorAlu, crit_orden);
					break;
				case 2:
					OrdenarAuxAlumno(alumnos, ref contadorAlu, crit_orden);
					break;
				case 3:
					OrdenarAuxAlumno(alumnos, ref contadorAlu, crit_orden);
					break;
			}
		}
		while(ok==false);	
	}
	
	static void OrdenarAuxAlumno(caracAlum[] alumnos, ref int contadorAlu, int crit_orden) // Lo que está comentado es básicamente para probar si funciona realmente la ordenación
	{
		if(crit_orden==1)
		{
			for(int i=0; i<contadorAlu-1; i++)
			{
				/*for(int k=0; k<contadorAlu; k++)
				{
					Console.WriteLine("Los apellidos del alumno {0} son {1}",k+1,alumnos[k].apellidos);
				}*/
				for(int j=i+1; j<contadorAlu; j++)
				{
					if(alumnos[i].apellidos.CompareTo(alumnos[j].apellidos) >=0)
					{
						string datoTemporal="";
						datoTemporal = alumnos[i].apellidos;
						alumnos[i].apellidos = alumnos[j].apellidos;
						alumnos[j].apellidos = datoTemporal;
					}
				}
			}
			/*for(int k=0; k<contadorAlu; k++)
			{
				Console.WriteLine("Ahora los apellidos del alumno {0} son {1}",k+1,alumnos[k].apellidos);
			}*/
		}
		
		if(crit_orden==2)
		{
			for(int i=0; i<contadorAlu-1; i++)
			{
				/*for(int k=0; k<3; k++)
				{
					Console.WriteLine("El DNI del alumno {0} es {1}",k+1,alumnos[k].dni);
				}*/
				for(int j=i+1; j<contadorAlu; j++)
				{
					if(alumnos[i].dni.CompareTo(alumnos[j].dni) <=0)
					{
						string datoTemporal="";
						datoTemporal = alumnos[i].dni;
						alumnos[i].dni = alumnos[j].dni;
						alumnos[j].dni = datoTemporal;
					}
				}
			}
			/*for(int k=0; k<3; k++)
			{
				Console.WriteLine("Ahora el DNI del alumno {0} es {1}",k+1,alumnos[k].dni);
			}*/
		}
		if(crit_orden==3)
		{
			for(int i=0; i<contadorAlu-1; i++)
			{
				/*for(int k=0; k<contadorAlu; k++)
				{
					Console.WriteLine("La ciudad del alumno {0} es {1}",k+1,alumnos[k].ciudad);
				}*/
				for(int j=i+1; j<contadorAlu; j++)
				{
					if(alumnos[i].ciudad.CompareTo(alumnos[j].ciudad) <=0)
					{
						string datoTemporal="";
						datoTemporal = alumnos[i].ciudad;
						alumnos[i].ciudad = alumnos[j].ciudad;
						alumnos[j].ciudad = datoTemporal;
					}
				}
			}
			/*for(int k=0; k<contadorAlu; k++)
			{
				Console.WriteLine("Ahora la ciudad del alumno {0} es {1}",k+1,alumnos[k].ciudad);
			}*/
		}
	}
	
	static void BuscarAlumnos(caracAlum[] alumnos, ref int contadorAlu)
	{
		int crit_busqueda=0;
		string cadena_buscar="";
		bool ok=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce el criterio de búsqueda (Pulsa 2 para buscar por DNI o Pulsa 1 para buscar por apellidos):");
				crit_busqueda=Convert.ToInt32(Console.ReadLine());
				if(crit_busqueda<1 || crit_busqueda>2) throw new Exception("Solo hay dos criterios de búsqueda, pulsa 1 o 2");
				if(Convert.ToString(crit_busqueda)=="") throw new Exception("Este campo no puede estar vacío");
				if(crit_busqueda==2)
				{
					Console.WriteLine("Introduce el DNI a buscar:");
					cadena_buscar=Console.ReadLine();
					if(cadena_buscar=="") throw new Exception("Este campo no puede estar vacío");
					if(cadena_buscar.Length!=9) throw new Exception("Un DNI tiene 8 números y 1 letra");
				}
				else
				{
					Console.WriteLine("Introduce el apellido o los apellidos a buscar:");
					cadena_buscar=Console.ReadLine();
					if(cadena_buscar=="") throw new Exception("Este campo no puede estar vacío");
				}
				ok=true;
			}
			catch(FormatException)
			{
				Console.WriteLine("Error: no es un valor válido");
			}
			catch(Exception e)
			{
				Console.WriteLine("{0}",e.Message);
			}
		}
		while(ok==false);
		int izquierda=0, derecha=0/*alumnos.Length-1*/;
		if(crit_busqueda==2)
		{
			OrdenarAuxAlumno(alumnos, ref contadorAlu, crit_busqueda);
			BusquedaRecursiva(alumnos, cadena_buscar, crit_busqueda, izquierda, derecha);
		}
		else
		{
			OrdenarAuxAlumno(alumnos, ref contadorAlu, crit_busqueda);
			Console.WriteLine("El alumno se encuentra en la posición {0}",BusquedaRecursiva(alumnos, cadena_buscar, crit_busqueda, izquierda, derecha));
			/*if(BusquedaRecursiva(alumnos, cadena_buscar, crit_busqueda)==-1 Console.WriteLine("No se ha encontrado ningún alumno coincidente");
			 * else MostrarDatos(alumnos, punto_medio)*/
		}
	}
	
	/*He intentado hacer la búsqueda binaria recursiva pero no me ha salido y he dejado comentada otra manera que se me había ocurrido hacer pero que tampoco me funciona
	para que al menos veas que lo he intentado, si pudieses subir junto a la corrección la función para ver como se hace te lo agradecería*/
	static int BusquedaRecursiva(caracAlum[] alumnos, string cadena_buscar, int crit_busqueda, int izquierda, int derecha)
	{
		//int punto_medio = (alumnos.Length)/2;
		
		if(crit_busqueda==2)
		{
			return 12345;
		}
		else
		{
			if(izquierda>derecha) return -1;
			int indiceCentral=Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
			string valorCentral= alumnos[indiceCentral].apellidos;
			if(String.Compare(cadena_buscar,valorCentral,true)==0) return indiceCentral;
			if(String.Compare(cadena_buscar,valorCentral,true)<0) derecha=indiceCentral-1;
			else izquierda=indiceCentral+1;
			return BusquedaRecursiva(alumnos, cadena_buscar, crit_busqueda, izquierda, derecha);
		}
		/*else
		{
			if(punto_medio>alumnos.Length) return -1;
			if(String.Compare(cadena_buscar,alumnos[punto_medio].apellidos,true)==0) return punto_medio;
			else
			{
				if(String.Compare(cadena_buscar,alumnos[punto_medio].apellidos,true)>0)
				{
					punto_medio = punto_medio/2;
				}
				else
				{
					punto_medio = punto_medio*2;
				}
			}
			return BusquedaRecursiva(alumnos, cadena_buscar, crit_busqueda);
		}*/
	}
	
	static void MostrarAlumnos(caracAlum[] alumnos, ref int contadorAlu)
	{
		for(int i=0; i<contadorAlu; i++)
		{
			Console.WriteLine("El alumno {0} es {1}",i+1,alumnos[i].nombre + " " + alumnos[i].apellidos);
		}
	}
}
