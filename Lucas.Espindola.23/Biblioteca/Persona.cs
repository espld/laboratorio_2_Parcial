using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre,string apellido,DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre,string apellido,DateTime nacimiento,string barrioResidencia)
            :this(nombre,apellido,nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        //Propiedades
        public int Edad
        {
            //get { return this.nacimiento.Year; }
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get 
            {
                return $"{this.apellido} {this.nombre}"; 
            }
        }

        //Metodos
        internal abstract string FichaExtra();
        
        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD : {p.Edad}");
            sb.AppendLine(p.barrioResidencia);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.NombreCompleto;
        }
    }
}
