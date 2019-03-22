namespace Escritorio
{
    partial class ReportesEleccion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_informeCompleto = new System.Windows.Forms.Button();
            this.txt_finTodos = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_nombrePaciente = new System.Windows.Forms.Label();
            this.cmb_Paciente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_informePaciente = new System.Windows.Forms.Button();
            this.txt_finPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_os = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_informeOs = new System.Windows.Forms.Button();
            this.txt_finOS = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_inicioTodos = new System.Windows.Forms.MaskedTextBox();
            this.txt_inicioPaciente = new System.Windows.Forms.MaskedTextBox();
            this.txt_inicioOS = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_inicioTodos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_informeCompleto);
            this.groupBox1.Controls.Add(this.txt_finTodos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Si la fecha de inicio se encuentra vacia se generara un informe desde el inicio";
            // 
            // btn_informeCompleto
            // 
            this.btn_informeCompleto.Location = new System.Drawing.Point(607, 41);
            this.btn_informeCompleto.Name = "btn_informeCompleto";
            this.btn_informeCompleto.Size = new System.Drawing.Size(103, 32);
            this.btn_informeCompleto.TabIndex = 4;
            this.btn_informeCompleto.Text = "Generar Infrome";
            this.btn_informeCompleto.UseVisualStyleBackColor = true;
            this.btn_informeCompleto.Click += new System.EventHandler(this.btn_informeCompleto_Click);
            // 
            // txt_finTodos
            // 
            this.txt_finTodos.Location = new System.Drawing.Point(225, 32);
            this.txt_finTodos.Mask = "00/00/0000";
            this.txt_finTodos.Name = "txt_finTodos";
            this.txt_finTodos.Size = new System.Drawing.Size(106, 20);
            this.txt_finTodos.TabIndex = 3;
            this.txt_finTodos.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_inicioPaciente);
            this.groupBox2.Controls.Add(this.lbl_nombrePaciente);
            this.groupBox2.Controls.Add(this.cmb_Paciente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_informePaciente);
            this.groupBox2.Controls.Add(this.txt_finPaciente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Paciente";
            // 
            // lbl_nombrePaciente
            // 
            this.lbl_nombrePaciente.AutoSize = true;
            this.lbl_nombrePaciente.Location = new System.Drawing.Point(402, 57);
            this.lbl_nombrePaciente.Name = "lbl_nombrePaciente";
            this.lbl_nombrePaciente.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombrePaciente.TabIndex = 14;
            // 
            // cmb_Paciente
            // 
            this.cmb_Paciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Paciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Paciente.FormattingEnabled = true;
            this.cmb_Paciente.Location = new System.Drawing.Point(402, 29);
            this.cmb_Paciente.Name = "cmb_Paciente";
            this.cmb_Paciente.Size = new System.Drawing.Size(141, 21);
            this.cmb_Paciente.TabIndex = 13;
            this.cmb_Paciente.SelectedValueChanged += new System.EventHandler(this.cmb_Paciente_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Si la fecha de inicio se encuentra vacia se generara un informe desde el inicio";
            // 
            // btn_informePaciente
            // 
            this.btn_informePaciente.Location = new System.Drawing.Point(607, 29);
            this.btn_informePaciente.Name = "btn_informePaciente";
            this.btn_informePaciente.Size = new System.Drawing.Size(103, 32);
            this.btn_informePaciente.TabIndex = 10;
            this.btn_informePaciente.Text = "Generar Infrome";
            this.btn_informePaciente.UseVisualStyleBackColor = true;
            this.btn_informePaciente.Click += new System.EventHandler(this.btn_informePaciente_Click);
            // 
            // txt_finPaciente
            // 
            this.txt_finPaciente.Location = new System.Drawing.Point(225, 29);
            this.txt_finPaciente.Mask = "00/00/0000";
            this.txt_finPaciente.Name = "txt_finPaciente";
            this.txt_finPaciente.Size = new System.Drawing.Size(106, 20);
            this.txt_finPaciente.TabIndex = 9;
            this.txt_finPaciente.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inicio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_inicioOS);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmb_os);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_informeOs);
            this.groupBox3.Controls.Add(this.txt_finOS);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(27, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(729, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por Obra Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 22;
            // 
            // cmb_os
            // 
            this.cmb_os.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_os.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_os.FormattingEnabled = true;
            this.cmb_os.Location = new System.Drawing.Point(402, 39);
            this.cmb_os.Name = "cmb_os";
            this.cmb_os.Size = new System.Drawing.Size(141, 21);
            this.cmb_os.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "*Si la fecha de inicio se encuentra vacia se generara un informe desde el inicio";
            // 
            // btn_informeOs
            // 
            this.btn_informeOs.Location = new System.Drawing.Point(607, 39);
            this.btn_informeOs.Name = "btn_informeOs";
            this.btn_informeOs.Size = new System.Drawing.Size(103, 32);
            this.btn_informeOs.TabIndex = 18;
            this.btn_informeOs.Text = "Generar Infrome";
            this.btn_informeOs.UseVisualStyleBackColor = true;
            this.btn_informeOs.Click += new System.EventHandler(this.btn_informeOs_Click);
            // 
            // txt_finOS
            // 
            this.txt_finOS.Location = new System.Drawing.Point(225, 39);
            this.txt_finOS.Mask = "00/00/0000";
            this.txt_finOS.Name = "txt_finOS";
            this.txt_finOS.Size = new System.Drawing.Size(106, 20);
            this.txt_finOS.TabIndex = 17;
            this.txt_finOS.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Inicio";
            // 
            // txt_inicioTodos
            // 
            this.txt_inicioTodos.Location = new System.Drawing.Point(64, 32);
            this.txt_inicioTodos.Mask = "00/00/0000";
            this.txt_inicioTodos.Name = "txt_inicioTodos";
            this.txt_inicioTodos.Size = new System.Drawing.Size(106, 20);
            this.txt_inicioTodos.TabIndex = 3;
            this.txt_inicioTodos.ValidatingType = typeof(System.DateTime);
            // 
            // txt_inicioPaciente
            // 
            this.txt_inicioPaciente.Location = new System.Drawing.Point(65, 29);
            this.txt_inicioPaciente.Mask = "00/00/0000";
            this.txt_inicioPaciente.Name = "txt_inicioPaciente";
            this.txt_inicioPaciente.Size = new System.Drawing.Size(105, 20);
            this.txt_inicioPaciente.TabIndex = 15;
            this.txt_inicioPaciente.ValidatingType = typeof(System.DateTime);
            // 
            // txt_inicioOS
            // 
            this.txt_inicioOS.Location = new System.Drawing.Point(65, 39);
            this.txt_inicioOS.Mask = "00/00/0000";
            this.txt_inicioOS.Name = "txt_inicioOS";
            this.txt_inicioOS.Size = new System.Drawing.Size(105, 20);
            this.txt_inicioOS.TabIndex = 23;
            this.txt_inicioOS.ValidatingType = typeof(System.DateTime);
            // 
            // ReportesEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesEleccion";
            this.Text = "ReportesEleccion";
            this.Load += new System.EventHandler(this.ReportesEleccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_informeCompleto;
        private System.Windows.Forms.MaskedTextBox txt_finTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nombrePaciente;
        private System.Windows.Forms.ComboBox cmb_Paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_informePaciente;
        private System.Windows.Forms.MaskedTextBox txt_finPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_os;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_informeOs;
        private System.Windows.Forms.MaskedTextBox txt_finOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txt_inicioTodos;
        private System.Windows.Forms.MaskedTextBox txt_inicioPaciente;
        private System.Windows.Forms.MaskedTextBox txt_inicioOS;
    }
}