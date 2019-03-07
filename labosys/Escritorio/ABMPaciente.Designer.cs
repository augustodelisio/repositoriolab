namespace Escritorio
{
    partial class ABMPaciente
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_altapaciente = new System.Windows.Forms.Button();
            this.btn_bajapaciente = new System.Windows.Forms.Button();
            this.btn_modificarpaciente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(54, 481);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(133, 32);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(12, 12);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            this.dgv_pacientes.Size = new System.Drawing.Size(561, 306);
            this.dgv_pacientes.TabIndex = 5;
            this.dgv_pacientes.CurrentCellChanged += new System.EventHandler(this.dgv_pacientes_CurrentCellChanged);
            // 
            // btn_altapaciente
            // 
            this.btn_altapaciente.Location = new System.Drawing.Point(351, 340);
            this.btn_altapaciente.Name = "btn_altapaciente";
            this.btn_altapaciente.Size = new System.Drawing.Size(177, 34);
            this.btn_altapaciente.TabIndex = 6;
            this.btn_altapaciente.Text = "Nuevo Paciente";
            this.btn_altapaciente.UseVisualStyleBackColor = true;
            this.btn_altapaciente.Click += new System.EventHandler(this.btn_altapaciente_Click);
            // 
            // btn_bajapaciente
            // 
            this.btn_bajapaciente.Location = new System.Drawing.Point(351, 422);
            this.btn_bajapaciente.Name = "btn_bajapaciente";
            this.btn_bajapaciente.Size = new System.Drawing.Size(177, 34);
            this.btn_bajapaciente.TabIndex = 7;
            this.btn_bajapaciente.Text = "Deshabilitar";
            this.btn_bajapaciente.UseVisualStyleBackColor = true;
            this.btn_bajapaciente.Click += new System.EventHandler(this.btn_bajapaciente_Click);
            // 
            // btn_modificarpaciente
            // 
            this.btn_modificarpaciente.Location = new System.Drawing.Point(351, 380);
            this.btn_modificarpaciente.Name = "btn_modificarpaciente";
            this.btn_modificarpaciente.Size = new System.Drawing.Size(177, 36);
            this.btn_modificarpaciente.TabIndex = 8;
            this.btn_modificarpaciente.Text = "Modificar Paciente";
            this.btn_modificarpaciente.UseVisualStyleBackColor = true;
            this.btn_modificarpaciente.Click += new System.EventHandler(this.btn_modificarpaciente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 54);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por DNI";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(18, 25);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.Location = new System.Drawing.Point(351, 422);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(177, 34);
            this.btn_habilitar.TabIndex = 10;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = true;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // ABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 539);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarpaciente);
            this.Controls.Add(this.btn_bajapaciente);
            this.Controls.Add(this.btn_altapaciente);
            this.Controls.Add(this.dgv_pacientes);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Button btn_altapaciente;
        private System.Windows.Forms.Button btn_bajapaciente;
        private System.Windows.Forms.Button btn_modificarpaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_habilitar;
    }
}