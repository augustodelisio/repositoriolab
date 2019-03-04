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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(37, 424);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(96, 34);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(37, 68);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.Size = new System.Drawing.Size(557, 306);
            this.dgv_pacientes.TabIndex = 5;
            // 
            // btn_altapaciente
            // 
            this.btn_altapaciente.Location = new System.Drawing.Point(642, 101);
            this.btn_altapaciente.Name = "btn_altapaciente";
            this.btn_altapaciente.Size = new System.Drawing.Size(96, 34);
            this.btn_altapaciente.TabIndex = 6;
            this.btn_altapaciente.Text = "Alta Paciente";
            this.btn_altapaciente.UseVisualStyleBackColor = true;
            this.btn_altapaciente.Click += new System.EventHandler(this.btn_altapaciente_Click);
            // 
            // btn_bajapaciente
            // 
            this.btn_bajapaciente.Location = new System.Drawing.Point(642, 258);
            this.btn_bajapaciente.Name = "btn_bajapaciente";
            this.btn_bajapaciente.Size = new System.Drawing.Size(96, 34);
            this.btn_bajapaciente.TabIndex = 7;
            this.btn_bajapaciente.Text = "Baja Paciente";
            this.btn_bajapaciente.UseVisualStyleBackColor = true;
            // 
            // btn_modificarpaciente
            // 
            this.btn_modificarpaciente.Location = new System.Drawing.Point(642, 178);
            this.btn_modificarpaciente.Name = "btn_modificarpaciente";
            this.btn_modificarpaciente.Size = new System.Drawing.Size(96, 36);
            this.btn_modificarpaciente.TabIndex = 8;
            this.btn_modificarpaciente.Text = "Modificar Paciente";
            this.btn_modificarpaciente.UseVisualStyleBackColor = true;
            // 
            // ABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btn_modificarpaciente);
            this.Controls.Add(this.btn_bajapaciente);
            this.Controls.Add(this.btn_altapaciente);
            this.Controls.Add(this.dgv_pacientes);
            this.Controls.Add(this.btn_volver);
            this.Name = "ABMPaciente";
            this.Text = "ABMPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Button btn_altapaciente;
        private System.Windows.Forms.Button btn_bajapaciente;
        private System.Windows.Forms.Button btn_modificarpaciente;
    }
}