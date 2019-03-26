namespace Escritorio
{
    partial class OSPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSPaciente));
            this.dgv_ospacientes = new System.Windows.Forms.DataGridView();
            this.gb_paciente = new System.Windows.Forms.GroupBox();
            this.btn_agregarOSPaciente = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ospacientes)).BeginInit();
            this.gb_paciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ospacientes
            // 
            this.dgv_ospacientes.AllowUserToAddRows = false;
            this.dgv_ospacientes.AllowUserToDeleteRows = false;
            this.dgv_ospacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ospacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ospacientes.Location = new System.Drawing.Point(33, 31);
            this.dgv_ospacientes.MultiSelect = false;
            this.dgv_ospacientes.Name = "dgv_ospacientes";
            this.dgv_ospacientes.ReadOnly = true;
            this.dgv_ospacientes.Size = new System.Drawing.Size(665, 213);
            this.dgv_ospacientes.TabIndex = 0;
            // 
            // gb_paciente
            // 
            this.gb_paciente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gb_paciente.Controls.Add(this.btn_atras);
            this.gb_paciente.Controls.Add(this.btn_agregarOSPaciente);
            this.gb_paciente.Controls.Add(this.dgv_ospacientes);
            this.gb_paciente.Location = new System.Drawing.Point(21, 22);
            this.gb_paciente.Name = "gb_paciente";
            this.gb_paciente.Size = new System.Drawing.Size(746, 403);
            this.gb_paciente.TabIndex = 1;
            this.gb_paciente.TabStop = false;
            // 
            // btn_agregarOSPaciente
            // 
            this.btn_agregarOSPaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregarOSPaciente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarOSPaciente.Location = new System.Drawing.Point(568, 266);
            this.btn_agregarOSPaciente.Name = "btn_agregarOSPaciente";
            this.btn_agregarOSPaciente.Size = new System.Drawing.Size(130, 30);
            this.btn_agregarOSPaciente.TabIndex = 1;
            this.btn_agregarOSPaciente.Text = "Nueva OS ";
            this.btn_agregarOSPaciente.UseVisualStyleBackColor = false;
            this.btn_agregarOSPaciente.Click += new System.EventHandler(this.btn_agregarOSPaciente_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(15, 358);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 21;
            this.btn_atras.Text = "Volver";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // OSPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gb_paciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ospacientes)).EndInit();
            this.gb_paciente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ospacientes;
        private System.Windows.Forms.GroupBox gb_paciente;
        private System.Windows.Forms.Button btn_agregarOSPaciente;
        private System.Windows.Forms.Button btn_atras;
    }
}