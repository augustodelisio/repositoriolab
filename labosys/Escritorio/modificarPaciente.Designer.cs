﻿namespace Escritorio
{
    partial class modificarPaciente
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
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_modificarpaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Location = new System.Drawing.Point(82, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente existente";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(140, 153);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 5;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(45, 156);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(23, 13);
            this.lbl_dni.TabIndex = 4;
            this.lbl_dni.Text = "Dni";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(140, 94);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(45, 97);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
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
            // btn_modificarpaciente
            // 
            this.btn_modificarpaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_modificarpaciente.AutoSize = true;
            this.btn_modificarpaciente.Location = new System.Drawing.Point(222, 289);
            this.btn_modificarpaciente.Name = "btn_modificarpaciente";
            this.btn_modificarpaciente.Size = new System.Drawing.Size(75, 23);
            this.btn_modificarpaciente.TabIndex = 8;
            this.btn_modificarpaciente.Text = "Modificar";
            this.btn_modificarpaciente.UseVisualStyleBackColor = true;
            this.btn_modificarpaciente.Click += new System.EventHandler(this.btn_modificarpaciente_Click);
            // 
            // modificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarpaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "modificarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_modificarpaciente;
    }
}