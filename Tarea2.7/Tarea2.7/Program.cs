using System;

namespace Tarea2
{
	class Dado {
		public string color;
		public int valor;

		public Dado() {
			valor = 6;
			color = "Azul";
		}
		public Dado(string color, int valor) {
			this.valor = valor;
			this.color = color;
		}
		public void Muestra() {
			Console.WriteLine("El valor del dado es " + valor);
			Console.WriteLine("El color del dado es "+ color);
		}
		public static bool operator ==(Dado da1, Dado da2) {
			if (da1.valor != da2.valor) { return false; } return true;
		}

		public static bool operator !=(Dado da1, Dado da2)
		{
			if (da1.valor == da2.valor) { return false;} return true;
		}

		public static bool operator >(Dado da1, Dado da2)
		{
			if (da1.valor < da2.valor) { return false; }
			return true;
		}

		public static bool operator <(Dado da1, Dado da2)
		{
			if (da1.valor > da2.valor) { return false; }
			return true;
		}

	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			Dado d1 = new Dado();
			Dado d2 = new Dado("Verde", 12);
			Dado d3 = new Dado("Rosa", 7);

			if (d1 == d2) { Console.WriteLine("Los 2 dados son iguales"); } else { Console.WriteLine("Los 2 dado no son iguales");}

			if (d1 > d3) { Console.WriteLine("Dado 1 es mayor a dado 3"); } else { Console.WriteLine("Dado 1  no es mayor a dado 3"); }

			if (d3 < d2) { Console.WriteLine("Dado 2 es mayor a dado 3"); } else { Console.WriteLine("Dado 2 no es mayor a dado 3"); }



		}
	}
}
