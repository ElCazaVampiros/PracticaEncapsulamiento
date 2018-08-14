using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto
            Contacto ContactoUno = new Contacto();

            ContactoUno.Nombre = "Andres Sanchez";
            ContactoUno.Direccion = "Sonora";
            ContactoUno.CorreoElectronico = "El_AndreSs99@hotmail.com";
            ContactoUno.TelefonoCasa = "4182816";
            ContactoUno.TelefonoCelular = "6441175923";

            Console.WriteLine("Nombre: " + ContactoUno.Nombre);
            Console.WriteLine("Direccion: " + ContactoUno.Direccion);
            Console.WriteLine("Correo electronico: " + ContactoUno.CorreoElectronico);
            Console.WriteLine("Telefono de casa: " + ContactoUno.TelefonoCasa);
            Console.WriteLine("Telefono celular: " + ContactoUno.TelefonoCelular);

            Console.ReadLine();
        }
    }
}