using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente: Persona
    {
        public string diagnostico;

        public Paciente(string nombre,string apellido,DateTime nacimiento,string barrioResidencia)
            :base(nombre,apellido,nacimiento,barrioResidencia)
        {
        }

        //Propiedades

        public string Diagnostico
        {
            get { return this.diagnostico; }
            set { this.diagnostico = value; }
        }      

        //Metodos
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Reside en: {this.barrioResidencia}");
            sb.AppendLine(this.Diagnostico);

            return sb.ToString();
        }
    }
}
