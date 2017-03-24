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

		public void lanza(){
			Random rng = new Random();
			this.valor = rng.Next(1,13);
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
			d1.lanza();
			d1.Muestra();
			Dado d2 = new Dado("Verde", 12);
			d2.lanza();
			d2.Muestra();
			Dado d3 = new Dado("Rosa", 7);
			d3.lanza();
			d3.Muestra();
			Dado mayor;
			if (d1 == d2 || d2 == d3) { Console.WriteLine("Al menos 2 dados son iguales"); }
			else { Console.WriteLine("Al menos 2 dado no son iguales");}

			if (d1 > d3) { mayor = d1; Console.WriteLine("Dado 1 es mayor a dado 3"); }
			else { mayor = d3; Console.WriteLine("Dado 1  no es mayor a dado 3"); }

			if (d2 > mayor) { mayor = d2; Console.WriteLine("Dado 2 es mayor a dado 3"); }
			else { mayor = d3; Console.WriteLine("Dado 2 no es mayor a dado 3"); }



		}
	}
}
