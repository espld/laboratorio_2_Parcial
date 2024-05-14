namespace Vista
{
    partial class FrmAtencion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMedicos = new Label();
            lblPacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(42, 34);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 0;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(346, 34);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 1;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(38, 71);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(276, 244);
            lstMedicos.TabIndex = 2;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(346, 71);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(276, 244);
            lstPacientes.TabIndex = 3;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(38, 352);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(584, 273);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(638, 71);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(138, 85);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(638, 540);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(138, 85);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 650);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lucas Espindola";
            FormClosing += FrmAtencion_FormClosing;
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicos;
        private Label lblPacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Button btnAtender;
        private Button btnSalir;
    }
}
