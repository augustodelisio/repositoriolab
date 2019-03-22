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
            this.cmb_pacientes = new System.Windows.Forms.ComboBox();
            this.grb_pacientes = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_os = new System.Windows.Forms.ComboBox();
            this.btn_agregarAnalisis = new System.Windows.Forms.Button();
            this.btn_nuevoPaciente = new System.Windows.Forms.Button();
            this.btn_nuevaOS = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.grb_pacientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // cmb_pacientes
            // 
            this.cmb_pacientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_pacientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_pacientes.CausesValidation = false;
            this.cmb_pacientes.FormattingEnabled = true;
            this.cmb_pacientes.Location = new System.Drawing.Point(109, 19);
            this.cmb_pacientes.Name = "cmb_pacientes";
            this.cmb_pacientes.Size = new System.Drawing.Size(132, 21);
            this.cmb_pacientes.TabIndex = 4;
            this.cmb_pacientes.SelectedValueChanged += new System.EventHandler(this.cmb_pacientes_SelectedValueChanged);
            // 
            // grb_pacientes
            // 
            this.grb_pacientes.Controls.Add(this.lbl_nombre);
            this.grb_pacientes.Controls.Add(this.cmb_pacientes);
            this.grb_pacientes.Location = new System.Drawing.Point(122, 113);
            this.grb_pacientes.Name = "grb_pacientes";
            this.grb_pacientes.Size = new System.Drawing.Size(277, 95);
            this.grb_pacientes.TabIndex = 6;
            this.grb_pacientes.TabStop = false;
            this.grb_pacientes.Text = "Paciente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(109, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_os);
            this.groupBox1.Location = new System.Drawing.Point(122, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obras Sociales";
            // 
            // cmb_os
            // 
            this.cmb_os.FormattingEnabled = true;
            this.cmb_os.Location = new System.Drawing.Point(112, 42);
            this.cmb_os.Name = "cmb_os";
            this.cmb_os.Size = new System.Drawing.Size(129, 21);
            this.cmb_os.TabIndex = 0;
            // 
            // btn_agregarAnalisis
            // 
            this.btn_agregarAnalisis.Location = new System.Drawing.Point(218, 374);
            this.btn_agregarAnalisis.Name = "btn_agregarAnalisis";
            this.btn_agregarAnalisis.Size = new System.Drawing.Size(155, 29);
            this.btn_agregarAnalisis.TabIndex = 8;
            this.btn_agregarAnalisis.Text = "Agregar Analisis";
            this.btn_agregarAnalisis.UseVisualStyleBackColor = true;
            this.btn_agregarAnalisis.Click += new System.EventHandler(this.btn_agregarAnalisis_Click);
            // 
            // btn_nuevoPaciente
            // 
            this.btn_nuevoPaciente.Location = new System.Drawing.Point(426, 132);
            this.btn_nuevoPaciente.Name = "btn_nuevoPaciente";
            this.btn_nuevoPaciente.Size = new System.Drawing.Size(106, 22);
            this.btn_nuevoPaciente.TabIndex = 10;
            this.btn_nuevoPaciente.Text = "Nuevo Paciente";
            this.btn_nuevoPaciente.UseVisualStyleBackColor = true;
            this.btn_nuevoPaciente.Click += new System.EventHandler(this.btn_nuevoPaciente_Click);
            // 
            // btn_nuevaOS
            // 
            this.btn_nuevaOS.Location = new System.Drawing.Point(426, 270);
            this.btn_nuevaOS.Name = "btn_nuevaOS";
            this.btn_nuevaOS.Size = new System.Drawing.Size(106, 23);
            this.btn_nuevaOS.TabIndex = 11;
            this.btn_nuevaOS.Text = "Nueva OS";
            this.btn_nuevaOS.UseVisualStyleBackColor = true;
            this.btn_nuevaOS.Click += new System.EventHandler(this.btn_nuevaOS_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(230, 62);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(132, 20);
            this.txt_fecha.TabIndex = 12;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // NuevoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 472);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_nuevaOS);
            this.Controls.Add(this.btn_nuevoPaciente);
            this.Controls.Add(this.btn_agregarAnalisis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_pacientes);
            this.Controls.Add(this.lbl_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NuevoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoExamen";
            this.grb_pacientes.ResumeLayout(false);
            this.grb_pacientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.ComboBox cmb_pacientes;
        private System.Windows.Forms.GroupBox grb_pacientes;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_os;
        private System.Windows.Forms.Button btn_agregarAnalisis;
        private System.Windows.Forms.Button btn_nuevoPaciente;
        private System.Windows.Forms.Button btn_nuevaOS;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
    }
}