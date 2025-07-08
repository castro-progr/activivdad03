using actividad03.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actividad03;


namespace actividad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop miLaptop = new laptop("L001", "HP", "Notebook 15", "AMD Ryzen 7", "Windows 11", 16, 1899.99m, "EF2565LA");

            Console.WriteLine("Información de la Laptop:");
            Console.WriteLine("Código: " + miLaptop.codigo);
            Console.WriteLine("Marca: " + miLaptop.marca);
            Console.WriteLine("Modelo: " + miLaptop.modelo);
            Console.WriteLine("Procesador: " + miLaptop.procesador);
            Console.WriteLine("Sistema Operativo: " + miLaptop.sistemaOperativo);
            Console.WriteLine("Memoria RAM: " + miLaptop.memoriaRAM + " GB");
            Console.WriteLine("Precio: $" + miLaptop.GetPrecio());

            Console.WriteLine("\nIntentando acceder al número de serie...");
            Console.Write("Ingrese el código de seguridad: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Número de serie: " + miLaptop.GetNumeroSerie(codigo));

            Console.WriteLine("\nActualizando precio...");
            Console.Write("Ingrese el nuevo precio: ");
            decimal nuevoPrecio = Convert.ToDecimal(Console.ReadLine());
            miLaptop.SetPrecio(nuevoPrecio);
            Console.WriteLine("Nuevo precio: $" + miLaptop.GetPrecio());

            Console.ReadLine();

            instanciarLaptop();
        }

        private static void instanciarLaptop()
        {
            Console.Clear();
            Console.WriteLine("INGRESE UNA NUEVA LAPTOP");
            Console.WriteLine();

            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Procesador: ");
            string procesador = Console.ReadLine();

            Console.Write("Sistema Operativo: ");
            string sistemaOperativo = Console.ReadLine();

            Console.Write("Memoria RAM (GB): ");
            int memoriaRAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Número de Serie: ");
            string numeroSerie = Console.ReadLine();

            laptop nuevaLaptop = new laptop(codigo, marca, modelo, procesador, sistemaOperativo, memoriaRAM, precio, numeroSerie);

            Console.WriteLine("\nLaptop registrada correctamente.");
            Console.WriteLine("Precio: $" + nuevaLaptop.GetPrecio());

            Console.Write("\nIngrese código de seguridad para ver el número de serie: ");
            string codigoSeguridad = Console.ReadLine();
            Console.WriteLine("Número de serie: " + nuevaLaptop.GetNumeroSerie(codigoSeguridad));

            Console.WriteLine("\nIngrese nuevo número de serie:");
            string nuevoNumeroSerie = Console.ReadLine();
            nuevaLaptop.SetNumeroSerie(nuevoNumeroSerie, codigoSeguridad);

            Console.WriteLine("Número de serie actualizado: " + nuevaLaptop.GetNumeroSerie(codigoSeguridad));

            Console.ReadLine();
        }
    }
}

