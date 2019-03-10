namespace Escritorio
{
    partial class AgregarOSPAciente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_afiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_OS = new System.Windows.Forms.ComboBox();
            this.btn_agregarOSaPaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_afiliado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_OS);
            this.groupBox1.Location = new System.Drawing.Point(116, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obas Sociales Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Afiliado";
            // 
            // txt_afiliado
            // 
            this.txt_afiliado.Location = new System.Drawing.Point(169, 98);
            this.txt_afiliado.Name = "txt_afiliado";
            this.txt_afiliado.Size = new System.Drawing.Size(172, 20);
            this.txt_afiliado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obras Sociales";
            // 
            // cmb_OS
            // 
            this.cmb_OS.FormattingEnabled = true;
            this.cmb_OS.Location = new System.Drawing.Point(169, 51);
            this.cmb_OS.Name = "cmb_OS";
            this.cmb_OS.Size = new System.Drawing.Size(172, 21);
            this.cmb_OS.TabIndex = 0;
            // 
            // btn_agregarOSaPaciente
            // 
            this.btn_agregarOSaPaciente.Location = new System.Drawing.Point(228, 218);
            this.btn_agregarOSaPaciente.Name = "btn_agregarOSaPaciente";
            this.btn_agregarOSaPaciente.Size = new System.Drawing.Size(150, 37);
            this.btn_agregarOSaPaciente.TabIndex = 1;
            this.btn_agregarOSaPaciente.Text = "Agregar OS a Paciente";
            this.btn_agregarOSaPaciente.UseVisualStyleBackColor = true;
            this.btn_agregarOSaPaciente.Click += new System.EventHandler(this.btn_agregarOSaPaciente_Click);
            // 
            // AgregarOSPAciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.btn_agregarOSaPaciente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarOSPAciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Obra Social a Paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_OS;
        private System.Windows.Forms.Button btn_agregarOSaPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_afiliado;
    }
}