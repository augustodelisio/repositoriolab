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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoExamen));
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
            this.btn_atras = new System.Windows.Forms.Button();
            this.grb_pacientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(116, 58);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(42, 15);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // cmb_pacientes
            // 
            this.cmb_pacientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_pacientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_pacientes.CausesValidation = false;
            this.cmb_pacientes.FormattingEnabled = true;
            this.cmb_pacientes.Location = new System.Drawing.Point(45, 19);
            this.cmb_pacientes.Name = "cmb_pacientes";
            this.cmb_pacientes.Size = new System.Drawing.Size(220, 23);
            this.cmb_pacientes.TabIndex = 4;
            this.cmb_pacientes.SelectedValueChanged += new System.EventHandler(this.cmb_pacientes_SelectedValueChanged);
            this.cmb_pacientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_pacientes_KeyUp);
            // 
            // grb_pacientes
            // 
            this.grb_pacientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_pacientes.Controls.Add(this.lbl_nombre);
            this.grb_pacientes.Controls.Add(this.cmb_pacientes);
            this.grb_pacientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_pacientes.Location = new System.Drawing.Point(74, 106);
            this.grb_pacientes.Name = "grb_pacientes";
            this.grb_pacientes.Size = new System.Drawing.Size(447, 95);
            this.grb_pacientes.TabIndex = 6;
            this.grb_pacientes.TabStop = false;
            this.grb_pacientes.Text = "Paciente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(109, 63);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(42, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cmb_os);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obras Sociales";
            // 
            // cmb_os
            // 
            this.cmb_os.CausesValidation = false;
            this.cmb_os.FormattingEnabled = true;
            this.cmb_os.Location = new System.Drawing.Point(45, 42);
            this.cmb_os.Name = "cmb_os";
            this.cmb_os.Size = new System.Drawing.Size(220, 23);
            this.cmb_os.TabIndex = 5;
            this.cmb_os.Tag = "botonOS";
            this.cmb_os.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_os_KeyUp);
            // 
            // btn_agregarAnalisis
            // 
            this.btn_agregarAnalisis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregarAnalisis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarAnalisis.Location = new System.Drawing.Point(239, 351);
            this.btn_agregarAnalisis.Name = "btn_agregarAnalisis";
            this.btn_agregarAnalisis.Size = new System.Drawing.Size(130, 30);
            this.btn_agregarAnalisis.TabIndex = 8;
            this.btn_agregarAnalisis.Text = "Agregar Analisis";
            this.btn_agregarAnalisis.UseVisualStyleBackColor = false;
            this.btn_agregarAnalisis.Click += new System.EventHandler(this.btn_agregarAnalisis_Click);
            // 
            // btn_nuevoPaciente
            // 
            this.btn_nuevoPaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevoPaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoPaciente.Location = new System.Drawing.Point(378, 125);
            this.btn_nuevoPaciente.Name = "btn_nuevoPaciente";
            this.btn_nuevoPaciente.Size = new System.Drawing.Size(130, 30);
            this.btn_nuevoPaciente.TabIndex = 10;
            this.btn_nuevoPaciente.Text = "Nuevo Paciente";
            this.btn_nuevoPaciente.UseVisualStyleBackColor = false;
            this.btn_nuevoPaciente.Click += new System.EventHandler(this.btn_nuevoPaciente_Click);
            // 
            // btn_nuevaOS
            // 
            this.btn_nuevaOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevaOS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevaOS.Location = new System.Drawing.Point(378, 263);
            this.btn_nuevaOS.Name = "btn_nuevaOS";
            this.btn_nuevaOS.Size = new System.Drawing.Size(130, 30);
            this.btn_nuevaOS.TabIndex = 11;
            this.btn_nuevaOS.Text = "Nueva OS";
            this.btn_nuevaOS.UseVisualStyleBackColor = false;
            this.btn_nuevaOS.Click += new System.EventHandler(this.btn_nuevaOS_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(165, 52);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(88, 23);
            this.txt_fecha.TabIndex = 12;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 419);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 18;
            this.btn_atras.Text = "Cerrar";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // NuevoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_nuevaOS);
            this.Controls.Add(this.btn_nuevoPaciente);
            this.Controls.Add(this.btn_agregarAnalisis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_pacientes);
            this.Controls.Add(this.lbl_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Examen";
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
        private System.Windows.Forms.Button btn_atras;
    }
}