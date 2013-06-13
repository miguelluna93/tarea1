using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea1
{
	class Persona
	{
		public String nombre;
		public int telefono;
		public String face;
		public String Domicilio;
		
		public Persona(){
			
		}
		
		
		public String mostrarNombre(){
			Console.Write ("Su nombre es: ");
			return this.nombre;
		}
		
		public int mostrarTelefono(){
			Console.Write ("Su telefono es: ");
			return this.telefono;
		}
		public String mostrarDomicilio(){
			Console.Write ("Su domicilio es: ");
			return this.Domicilio;
		}
		public String mostrarFacebook(){
			Console.Write ("Su Facebook es: ");
			return this.face;
		}
	
		
		
		public static void Main (string[] args)
		{
		    Persona persona = new Persona();

			Console.WriteLine("Dame tu nombre:");
		    persona.nombre = Console.ReadLine();
			Console.WriteLine("Dame tu telefono:");
		    persona.telefono= int.Parse( Console.ReadLine() );
			Console.WriteLine("Dame tu facebook:");
		    persona.face = Console.ReadLine();
			Console.WriteLine("Dame tu Domicilio:");
		    persona.Domicilio = Console.ReadLine();
			Console.WriteLine("");
			//Mostrar en pantalla lo introducido
			Console.WriteLine(persona.mostrarNombre());
			Console.WriteLine(persona.mostrarTelefono());
			Console.WriteLine(persona.mostrarFacebook());
			Console.WriteLine(persona.mostrarDomicilio());
			
		}
	}
}
