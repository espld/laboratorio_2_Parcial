using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico: Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool  esResidente)
            :base(nombre,apellido,nacimiento)
        {
            this.esResidente = esResidente;
        }

        //Metodos
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();       

            sb.AppendLine(base.ToString());
            sb.AppendLine($"¿Finalizó residencia? {this.esResidente}");
            sb.AppendLine("ATENCIONES: ");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        //Sobrecarga

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);

            doctor.consultas.Add(consulta);

            return consulta;


        }










    }
}
