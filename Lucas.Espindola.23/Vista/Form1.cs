using Biblioteca;

namespace Vista
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if(this.lstMedicos.SelectedItem == null || this.lstPacientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Médico y un Paciente para poder continuar.","Error en los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                foreach (Paciente item in this.lstPacientes.Items)
                {
                    Consulta consulta = new Consulta(DateTime.Now, item);
                    consulta.Paciente.Diagnostico = "Paciente curado";
                    MessageBox.Show(consulta.ToString(), "Atencion finalizada", MessageBoxButtons.OK);
                }
                lstMedicos.SelectedItems.Clear();
                lstPacientes.SelectedItems.Clear();
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
