namespace Escritorio
{
    partial class modificarOS
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
            this.components = new System.ComponentModel.Container();
            this.gbx_modificar = new System.Windows.Forms.GroupBox();
            this.lbl_actoBioquimico = new System.Windows.Forms.Label();
            this.txt_actoBioquimico = new System.Windows.Forms.TextBox();
            this.txt_nbu = new System.Windows.Forms.TextBox();
            this.lbl_nbu = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_ModificarOS = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_modificar
            // 
            this.gbx_modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_modificar.Controls.Add(this.lbl_actoBioquimico);
            this.gbx_modificar.Controls.Add(this.txt_actoBioquimico);
            this.gbx_modificar.Controls.Add(this.txt_nbu);
            this.gbx_modificar.Controls.Add(this.lbl_nbu);
            this.gbx_modificar.Controls.Add(this.txt_porcentaje);
            this.gbx_modificar.Controls.Add(this.lbl_porcentaje);
            this.gbx_modificar.Controls.Add(this.txt_nombre);
            this.gbx_modificar.Controls.Add(this.lbl_nombre);
            this.gbx_modificar.Location = new System.Drawing.Point(83, 51);
            this.gbx_modificar.Name = "gbx_modificar";
            this.gbx_modificar.Size = new System.Drawing.Size(323, 228);
            this.gbx_modificar.TabIndex = 10;
            this.gbx_modificar.TabStop = false;
            this.gbx_modificar.Text = "Obra Social existente";
            // 
            // lbl_actoBioquimico
            // 
            this.lbl_actoBioquimico.AutoSize = true;
            this.lbl_actoBioquimico.Location = new System.Drawing.Point(20, 205);
            this.lbl_actoBioquimico.Name = "lbl_actoBioquimico";
            this.lbl_actoBioquimico.Size = new System.Drawing.Size(83, 13);
            this.lbl_actoBioquimico.TabIndex = 11;
            this.lbl_actoBioquimico.Text = "Acto Bioquimico";
            // 
            // txt_actoBioquimico
            // 
            this.txt_actoBioquimico.Location = new System.Drawing.Point(140, 198);
            this.txt_actoBioquimico.Name = "txt_actoBioquimico";
            this.txt_actoBioquimico.Size = new System.Drawing.Size(117, 20);
            this.txt_actoBioquimico.TabIndex = 10;
            // 
            // txt_nbu
            // 
            this.txt_nbu.Location = new System.Drawing.Point(140, 145);
            this.txt_nbu.Name = "txt_nbu";
            this.txt_nbu.Size = new System.Drawing.Size(117, 20);
            this.txt_nbu.TabIndex = 9;
            // 
            // lbl_nbu
            // 
            this.lbl_nbu.AutoSize = true;
            this.lbl_nbu.Location = new System.Drawing.Point(76, 148);
            this.lbl_nbu.Name = "lbl_nbu";
            this.lbl_nbu.Size = new System.Drawing.Size(27, 13);
            this.lbl_nbu.TabIndex = 8;
            this.lbl_nbu.Text = "Nbu";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(140, 94);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(117, 20);
            this.txt_porcentaje.TabIndex = 3;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(45, 97);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(58, 13);
            this.lbl_porcentaje.TabIndex = 2;
            this.lbl_porcentaje.Text = "Porcentaje";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(117, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(45, 39);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // btn_ModificarOS
            // 
            this.btn_ModificarOS.Location = new System.Drawing.Point(223, 300);
            this.btn_ModificarOS.Name = "btn_ModificarOS";
            this.btn_ModificarOS.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarOS.TabIndex = 11;
            this.btn_ModificarOS.Text = "Modificar";
            this.btn_ModificarOS.UseVisualStyleBackColor = true;
            this.btn_ModificarOS.Click += new System.EventHandler(this.btn_ModificarOS_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // modificarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.btn_ModificarOS);
            this.Controls.Add(this.gbx_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "modificarOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Obra Social";
            this.gbx_modificar.ResumeLayout(false);
            this.gbx_modificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_modificar;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_ModificarOS;
        private System.Windows.Forms.Label lbl_actoBioquimico;
        private System.Windows.Forms.TextBox txt_actoBioquimico;
        private System.Windows.Forms.TextBox txt_nbu;
        private System.Windows.Forms.Label lbl_nbu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}