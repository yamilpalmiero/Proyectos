using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medicamento
    {
        private string nombre;
        private string codigo;
        private DateTime fechaVencimiento;
        private int stock;

        protected Medicamento(string nombre, string codigo, int stock)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.fechaVencimiento = DateTime.Now;
            this.stock = stock;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                if (Validar(value))
                {
                    this.codigo = value;
                }
            }
        }
        public DateTime FechaVencimiento
        {
            get
            {
                return this.fechaVencimiento;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    this.fechaVencimiento = value;
                }
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public static bool operator ==(Medicamento m, Comprimido c)
        {
            bool retorno = false;

            if (m.GetType() == c.GetType())
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Medicamento m, Comprimido c)
        {
            return !(m == c);
        }
        public static bool operator ==(List<Medicamento> listaMedicamentos, Medicamento medicamento)
        {
            bool retorno = false;

            foreach (Medicamento m in listaMedicamentos)
            {
                if (medicamento.Nombre.Equals(m.Nombre))
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(List<Medicamento> listaMedicamentos, Medicamento medicamento)
        {
            return !(listaMedicamentos == medicamento);
        }
        public static List<Medicamento> operator +(List<Medicamento> listaMedicamentos, Medicamento medicamento)
        {
            if (listaMedicamentos != medicamento)
            {
                listaMedicamentos.Add(medicamento);
            }

            return listaMedicamentos;
        }

        public bool Validar(string cadena)
        {
            bool retorno = false;

            if (cadena.Length == 6)
            {
                retorno = true;
            }

            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Codigo: {this.codigo}");

            return sb.ToString();
        }
    }
}
