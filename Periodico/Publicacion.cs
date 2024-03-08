using Periodico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico
{
    public class Publicacion
    {
        public int NumeroHojas { get; set; }
        public double ValorHoja { get; set; }
        public string Titulo { get; set; }
        public string TipoPortada { get; set; }
        public string NombreAutor { get; set; }
        public string Fecha { get; set; }
        public bool HojasColor { get; set; }

        public Publicacion(int numHojas, double valorHoja, string titulo, string tipoPortada, string autor, string fecha, bool color)
        {
            NumeroHojas = numHojas;
            ValorHoja = valorHoja;
            Titulo = titulo;
            TipoPortada = tipoPortada;
            NombreAutor = autor;
            Fecha = fecha;
            HojasColor = color;
        }

        public double CalcularCosto()
        {
            double costo = NumeroHojas * ValorHoja;

            switch (TipoPortada.ToLower())
            {
                case "lujo":
                    costo += 15000;
                    break;
                case "normal":
                    costo += 10000;
                    break;
                case "económica":
                    costo += 5000;
                    break;
                default:
                    Console.WriteLine("Tipo de portada no válido. Se asumirá portada normal.");
                    costo += 10000;
                    break;
            }

            if (HojasColor)
            {
                costo += 500 * NumeroHojas;
            }

            return costo;
        }
    }
}

