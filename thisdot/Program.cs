using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisdot
{
    // class Usuario
    {
        private int numControl;
        private string nombre;
        private string correo;

        public void set_id()
        {
            Console.Write("Ingrese el no.control:");
            numControl = int.Parse(Console.ReadLine());
        }
        public void set_user()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
        }
        public void set_mail()
        {
            Console.Write("Ingrese el correo:");
            correo = Console.ReadLine();
        }

        public void get_user()
        {
           // Console.WriteLine("ID: {0} , Nombre: {1} , Correo: {2} ", numControl, nombre, correo);
            Console.Write("No.Control:");
            Console.WriteLine(numControl);
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Correo:");
            Console.WriteLine(correo);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user1 = new Usuario();
            Usuario user2 = new Usuario();
            user1.set_id();
            user1.set_user();
            user1.set_mail();
            user1.get_user();
            user2.set_id();
            user2.set_user();
            user2.set_mail();
            user2.get_user();


        }
    }
}
