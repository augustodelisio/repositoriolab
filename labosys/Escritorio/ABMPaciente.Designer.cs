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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMPaciente));
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_altapaciente = new System.Windows.Forms.Button();
            this.btn_bajapaciente = new System.Windows.Forms.Button();
            this.btn_modificarpaciente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_filtroDni = new System.Windows.Forms.TextBox();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.btn_obrasSocialesPaciente = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AllowUserToAddRows = false;
            this.dgv_pacientes.AllowUserToDeleteRows = false;
            this.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(12, 12);
            this.dgv_pacientes.MultiSelect = false;
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            this.dgv_pacientes.Size = new System.Drawing.Size(561, 306);
            this.dgv_pacientes.TabIndex = 5;
            this.dgv_pacientes.CurrentCellChanged += new System.EventHandler(this.dgv_pacientes_CurrentCellChanged);
            // 
            // btn_altapaciente
            // 
            this.btn_altapaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_altapaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altapaciente.Location = new System.Drawing.Point(393, 348);
            this.btn_altapaciente.Name = "btn_altapaciente";
            this.btn_altapaciente.Size = new System.Drawing.Size(180, 35);
            this.btn_altapaciente.TabIndex = 6;
            this.btn_altapaciente.Text = "Nuevo Paciente";
            this.btn_altapaciente.UseVisualStyleBackColor = false;
            this.btn_altapaciente.Click += new System.EventHandler(this.btn_altapaciente_Click);
            // 
            // btn_bajapaciente
            // 
            this.btn_bajapaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bajapaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bajapaciente.Location = new System.Drawing.Point(393, 434);
            this.btn_bajapaciente.Name = "btn_bajapaciente";
            this.btn_bajapaciente.Size = new System.Drawing.Size(180, 35);
            this.btn_bajapaciente.TabIndex = 7;
            this.btn_bajapaciente.Text = "Deshabilitar";
            this.btn_bajapaciente.UseVisualStyleBackColor = false;
            this.btn_bajapaciente.Click += new System.EventHandler(this.btn_bajapaciente_Click);
            // 
            // btn_modificarpaciente
            // 
            this.btn_modificarpaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_modificarpaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarpaciente.Location = new System.Drawing.Point(393, 392);
            this.btn_modificarpaciente.Name = "btn_modificarpaciente";
            this.btn_modificarpaciente.Size = new System.Drawing.Size(180, 35);
            this.btn_modificarpaciente.TabIndex = 8;
            this.btn_modificarpaciente.Text = "Modificar Paciente";
            this.btn_modificarpaciente.UseVisualStyleBackColor = false;
            this.btn_modificarpaciente.Click += new System.EventHandler(this.btn_modificarpaciente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.txt_filtroDni);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 54);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por DNI";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(18, 25);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(35, 17);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.Text = "DNI:";
            // 
            // txt_filtroDni
            // 
            this.txt_filtroDni.Location = new System.Drawing.Point(78, 22);
            this.txt_filtroDni.Name = "txt_filtroDni";
            this.txt_filtroDni.Size = new System.Drawing.Size(150, 23);
            this.txt_filtroDni.TabIndex = 0;
            this.txt_filtroDni.TextChanged += new System.EventHandler(this.txt_filtroDni_TextChanged);
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_habilitar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitar.Location = new System.Drawing.Point(393, 434);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(180, 35);
            this.btn_habilitar.TabIndex = 10;
            this.btn_habilitar.Text = "Habilitar";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            this.btn_habilitar.Click += new System.EventHandler(this.btn_habilitar_Click);
            // 
            // btn_obrasSocialesPaciente
            // 
            this.btn_obrasSocialesPaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_obrasSocialesPaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrasSocialesPaciente.Location = new System.Drawing.Point(393, 475);
            this.btn_obrasSocialesPaciente.Name = "btn_obrasSocialesPaciente";
            this.btn_obrasSocialesPaciente.Size = new System.Drawing.Size(180, 35);
            this.btn_obrasSocialesPaciente.TabIndex = 11;
            this.btn_obrasSocialesPaciente.Text = "Obras Sociales";
            this.btn_obrasSocialesPaciente.UseVisualStyleBackColor = false;
            this.btn_obrasSocialesPaciente.Click += new System.EventHandler(this.btn_obrasSocialesPaciente_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 519);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 12;
            this.btn_atras.Text = "Volver";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // ABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_obrasSocialesPaciente);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarpaciente);
            this.Controls.Add(this.btn_bajapaciente);
            this.Controls.Add(this.btn_altapaciente);
            this.Controls.Add(this.dgv_pacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Button btn_altapaciente;
        private System.Windows.Forms.Button btn_bajapaciente;
        private System.Windows.Forms.Button btn_modificarpaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_filtroDni;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button btn_obrasSocialesPaciente;
        private System.Windows.Forms.Button btn_atras;
    }
}