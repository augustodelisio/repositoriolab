﻿namespace Escritorio
{
    partial class ABMAnalisis
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_modificarAnalisis = new System.Windows.Forms.Button();
            this.btn_altaAnalisis = new System.Windows.Forms.Button();
            this.dgv_analisis = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(133, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 54);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por nombre";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(18, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_modificarAnalisis
            // 
            this.btn_modificarAnalisis.Location = new System.Drawing.Point(467, 421);
            this.btn_modificarAnalisis.Name = "btn_modificarAnalisis";
            this.btn_modificarAnalisis.Size = new System.Drawing.Size(177, 36);
            this.btn_modificarAnalisis.TabIndex = 15;
            this.btn_modificarAnalisis.Text = "Modificar Analisis";
            this.btn_modificarAnalisis.UseVisualStyleBackColor = true;
            this.btn_modificarAnalisis.Click += new System.EventHandler(this.btn_modificarAnalisis_Click);
            // 
            // btn_altaAnalisis
            // 
            this.btn_altaAnalisis.Location = new System.Drawing.Point(467, 381);
            this.btn_altaAnalisis.Name = "btn_altaAnalisis";
            this.btn_altaAnalisis.Size = new System.Drawing.Size(177, 34);
            this.btn_altaAnalisis.TabIndex = 13;
            this.btn_altaAnalisis.Text = "Nuevo Analisis";
            this.btn_altaAnalisis.UseVisualStyleBackColor = true;
            this.btn_altaAnalisis.Click += new System.EventHandler(this.btn_altaAnalisis_Click);
            // 
            // dgv_analisis
            // 
            this.dgv_analisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_analisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analisis.Location = new System.Drawing.Point(93, 51);
            this.dgv_analisis.Name = "dgv_analisis";
            this.dgv_analisis.ReadOnly = true;
            this.dgv_analisis.Size = new System.Drawing.Size(561, 306);
            this.dgv_analisis.TabIndex = 12;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(170, 522);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(133, 32);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // ABMAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarAnalisis);
            this.Controls.Add(this.btn_altaAnalisis);
            this.Controls.Add(this.dgv_analisis);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ABMAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Analisis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_modificarAnalisis;
        private System.Windows.Forms.Button btn_altaAnalisis;
        private System.Windows.Forms.DataGridView dgv_analisis;
        private System.Windows.Forms.Button btn_volver;
    }
}