using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad03.clases
{
    public class laptop
    {
        public string codigo;
        public string marca;
        public string modelo;
        public string procesador;
        public string sistemaOperativo;
        public int memoriaRAM;
        private decimal precio;
        private string numeroSerie;

        public laptop(string codigo, string marca, string modelo, string procesador, string sistemaOperativo, int memoriaRAM, decimal precio, string numeroSerie)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
            this.memoriaRAM = memoriaRAM;
            this.precio = precio;
            this.numeroSerie = numeroSerie;
        }

        public decimal GetPrecio()
        {
            return precio;
        }

        public void SetPrecio(decimal nuevoPrecio)
        {
            if (nuevoPrecio > 0)
            {
                precio = nuevoPrecio;
            }
            else
            {
                Console.WriteLine("El precio debe ser mayor a 0.");
            }
        }

        public string GetNumeroSerie(string codigoSeguridad)
        {
            if (codigoSeguridad == "castro.jav7")
            {
                return numeroSerie;
            }
            else
            {
                return "Acceso denegado: código incorrecto.";
            }
        }

        public void SetNumeroSerie(string nuevoNumeroSerie, string codigoSeguridad)
        {
            if (codigoSeguridad == "castro.jav7")
            {
                numeroSerie = nuevoNumeroSerie;
            }
            else
            {
                Console.WriteLine("No autorizado para modificar el número de serie.");
            }
        }
    }
}


