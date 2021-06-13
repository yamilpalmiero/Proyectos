using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento[] medicamentos =
            {
                new Comprimido("Omeprazol", "DASDA", 2500, 14, Comprimido.ETipoVenta.Recetado),
                new Comprimido("Ibuprofeno", "RWREWR", 500, 10, Comprimido.ETipoVenta.VentaLibre),
                new Comprimido("Paracetamol", "JTJYTJ", 650, 20, Comprimido.ETipoVenta.VentaLibre),
                new Inyectable("Corticoides", "QWSDF", 200, -65.5f, Inyectable.EAplicacion.Endovenosa),
                new Inyectable("Buscapina", "ASDGFH", 100, -05.8f, Inyectable.EAplicacion.Intramuscular)
            };

            foreach (Medicamento item in medicamentos)
            {
                if (item is Comprimido)
                {
                    Console.WriteLine("COMPRIMIDO:");
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    Console.WriteLine("INYECTABLE:");
                    Console.WriteLine(item.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}

