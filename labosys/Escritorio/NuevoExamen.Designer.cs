namespace Escritorio
{
    partial class NuevoExamen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.mtb_fecha = new System.Windows.Forms.MaskedTextBox();
            this.cmb_pacientes = new System.Windows.Forms.ComboBox();
            this.lbl_muestraNom = new System.Windows.Forms.Label();
            this.grb_pacientes = new System.Windows.Forms.GroupBox();
            this.grb_pacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(119, 69);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // mtb_fecha
            // 
            this.mtb_fecha.Location = new System.Drawing.Point(231, 66);
            this.mtb_fecha.Mask = "00/00/0000";
            this.mtb_fecha.Name = "mtb_fecha";
            this.mtb_fecha.Size = new System.Drawing.Size(129, 20);
            this.mtb_fecha.TabIndex = 2;
            this.mtb_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_pacientes
            // 
            this.cmb_pacientes.FormattingEnabled = true;
            this.cmb_pacientes.Location = new System.Drawing.Point(109, 19);
            this.cmb_pacientes.Name = "cmb_pacientes";
            this.cmb_pacientes.Size = new System.Drawing.Size(132, 21);
            this.cmb_pacientes.TabIndex = 4;
            this.cmb_pacientes.SelectedValueChanged += new System.EventHandler(this.cmb_pacientes_SelectedValueChanged);
            this.cmb_pacientes.TextChanged += new System.EventHandler(this.cmb_pacientes_TextChanged);
            // 
            // lbl_muestraNom
            // 
            this.lbl_muestraNom.AutoSize = true;
            this.lbl_muestraNom.Location = new System.Drawing.Point(106, 64);
            this.lbl_muestraNom.Name = "lbl_muestraNom";
            this.lbl_muestraNom.Size = new System.Drawing.Size(44, 13);
            this.lbl_muestraNom.TabIndex = 5;
            this.lbl_muestraNom.Text = "Nombre";
            this.lbl_muestraNom.Visible = false;
            // 
            // grb_pacientes
            // 
            this.grb_pacientes.Controls.Add(this.lbl_muestraNom);
            this.grb_pacientes.Controls.Add(this.cmb_pacientes);
            this.grb_pacientes.Location = new System.Drawing.Point(122, 113);
            this.grb_pacientes.Name = "grb_pacientes";
            this.grb_pacientes.Size = new System.Drawing.Size(315, 95);
            this.grb_pacientes.TabIndex = 6;
            this.grb_pacientes.TabStop = false;
            this.grb_pacientes.Text = "Paciente";
            // 
            // NuevoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 472);
            this.Controls.Add(this.grb_pacientes);
            this.Controls.Add(this.mtb_fecha);
            this.Controls.Add(this.lbl_Fecha);
            this.Name = "NuevoExamen";
            this.Text = "NuevoExamen";
            this.grb_pacientes.ResumeLayout(false);
            this.grb_pacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.MaskedTextBox mtb_fecha;
        private System.Windows.Forms.ComboBox cmb_pacientes;
        private System.Windows.Forms.Label lbl_muestraNom;
        private System.Windows.Forms.GroupBox grb_pacientes;
    }
}