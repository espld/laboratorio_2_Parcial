using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        //Propiedades
        public DateTime Fecha
        {
            get { return this.fecha; }
        }
        public Paciente Paciente
        {
            get { return this.paciente; }
        }

        public override string ToString()
        {
            return $"{this.Fecha} se ha atentido a {this.Paciente.NombreCompleto}";
        }
        
    }
}
