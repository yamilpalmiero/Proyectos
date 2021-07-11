using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medicamento> medicamentos = new List<Medicamento>();

            medicamentos.Add(new Comprimido("Omeprazol", 2500, 14, Comprimido.ETipoVenta.Recetado));
            medicamentos.Add(new Comprimido("Ibuprofeno", 500, 10, Comprimido.ETipoVenta.VentaLibre));
            medicamentos.Add(new Comprimido("Paracetamol", 650, 20, Comprimido.ETipoVenta.VentaLibre));
            medicamentos.Add(new Inyectable("Corticoides", 200, 50, -65.5f, Inyectable.EAplicacion.Endovenosa));
            medicamentos.Add(new Inyectable("Buscapina", 100, 25, -05.8f, Inyectable.EAplicacion.Intramuscular));


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


