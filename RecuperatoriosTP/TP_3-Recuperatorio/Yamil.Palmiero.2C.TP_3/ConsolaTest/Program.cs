using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace ConsolaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratorio l = new Laboratorio();



            Medicamento m1 = new Medicamento("Omeprazol", ETipo.VentaLibre);
            Medicamento m2 = new Medicamento("Paracetamol", ETipo.VentaLibre);
            Medicamento m3 = new Medicamento("Ibuprofeno", ETipo.VentaLibre);

            Medicamento m4 = new Medicamento("Corticoides", ETipo.Recetado);
            Medicamento m5 = new Medicamento("Buscapina", ETipo.Recetado);
            Medicamento m6 = new Medicamento("Sputnik V", ETipo.Recetado);



            try
            {
                l.medicamentos.Add(m1);
                l.medicamentos.Add(m2);
                l.medicamentos.Add(m3);

                l.medicamentos.Add(m4);
                l.medicamentos.Add(m5);
                l.medicamentos.Add(m6);
            }
            catch (MedicamentoRepetidoException ex)
            {
                Console.WriteLine(ex.Message);
            }



            foreach (Medicamento m in l.medicamentos)
            {
                Console.WriteLine(m.ToString());
                Console.WriteLine("");
            }



            try
            {
                if (Laboratorio.Escribir(l, "DatosDeConsola.xml"))
                {
                    Console.WriteLine($"\nSe guardaron los datos en formato xml.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
