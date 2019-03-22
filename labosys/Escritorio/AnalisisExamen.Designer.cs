namespace Escritorio
{
    partial class AnalisisExamen
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
            this.dgv_analisis = new System.Windows.Forms.DataGridView();
            this.btn_agregarAnalisis = new System.Windows.Forms.Button();
            this.cmb_analisis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombreAnalisis = new System.Windows.Forms.Label();
            this.btn_guardarCambios = new System.Windows.Forms.Button();
            this.btn_eliminarAnalisis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_analisis
            // 
            this.dgv_analisis.AllowUserToAddRows = false;
            this.dgv_analisis.AllowUserToDeleteRows = false;
            this.dgv_analisis.AllowUserToOrderColumns = true;
            this.dgv_analisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_analisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analisis.Location = new System.Drawing.Point(36, 30);
            this.dgv_analisis.MultiSelect = false;
            this.dgv_analisis.Name = "dgv_analisis";
            this.dgv_analisis.ReadOnly = true;
            this.dgv_analisis.Size = new System.Drawing.Size(534, 168);
            this.dgv_analisis.TabIndex = 0;
            // 
            // btn_agregarAnalisis
            // 
            this.btn_agregarAnalisis.Location = new System.Drawing.Point(45, 21);
            this.btn_agregarAnalisis.Name = "btn_agregarAnalisis";
            this.btn_agregarAnalisis.Size = new System.Drawing.Size(113, 26);
            this.btn_agregarAnalisis.TabIndex = 1;
            this.btn_agregarAnalisis.Text = "Agregar Analisis";
            this.btn_agregarAnalisis.UseVisualStyleBackColor = true;
            this.btn_agregarAnalisis.Click += new System.EventHandler(this.btn_agregarAnalisis_Click);
            // 
            // cmb_analisis
            // 
            this.cmb_analisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_analisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_analisis.FormattingEnabled = true;
            this.cmb_analisis.Location = new System.Drawing.Point(193, 25);
            this.cmb_analisis.Name = "cmb_analisis";
            this.cmb_analisis.Size = new System.Drawing.Size(151, 21);
            this.cmb_analisis.TabIndex = 2;
            this.cmb_analisis.SelectedValueChanged += new System.EventHandler(this.cmb_analisis_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nombreAnalisis);
            this.groupBox1.Controls.Add(this.cmb_analisis);
            this.groupBox1.Controls.Add(this.btn_agregarAnalisis);
            this.groupBox1.Location = new System.Drawing.Point(205, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Analisis";
            // 
            // lbl_nombreAnalisis
            // 
            this.lbl_nombreAnalisis.AutoSize = true;
            this.lbl_nombreAnalisis.Location = new System.Drawing.Point(193, 53);
            this.lbl_nombreAnalisis.Name = "lbl_nombreAnalisis";
            this.lbl_nombreAnalisis.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombreAnalisis.TabIndex = 3;
            this.lbl_nombreAnalisis.Text = "label1";
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.Location = new System.Drawing.Point(205, 353);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.Size = new System.Drawing.Size(201, 39);
            this.btn_guardarCambios.TabIndex = 4;
            this.btn_guardarCambios.Text = "Guardar Cambios";
            this.btn_guardarCambios.UseVisualStyleBackColor = true;
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
            // 
            // btn_eliminarAnalisis
            // 
            this.btn_eliminarAnalisis.Location = new System.Drawing.Point(250, 306);
            this.btn_eliminarAnalisis.Name = "btn_eliminarAnalisis";
            this.btn_eliminarAnalisis.Size = new System.Drawing.Size(113, 26);
            this.btn_eliminarAnalisis.TabIndex = 5;
            this.btn_eliminarAnalisis.Text = "Eliminar Analisis";
            this.btn_eliminarAnalisis.UseVisualStyleBackColor = true;
            this.btn_eliminarAnalisis.Click += new System.EventHandler(this.btn_eliminarAnalisis_Click);
            // 
            // AnalisisExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.btn_eliminarAnalisis);
            this.Controls.Add(this.btn_guardarCambios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_analisis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalisisExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Analisis al Examen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_analisis;
        private System.Windows.Forms.Button btn_agregarAnalisis;
        private System.Windows.Forms.ComboBox cmb_analisis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nombreAnalisis;
        private System.Windows.Forms.Button btn_guardarCambios;
        private System.Windows.Forms.Button btn_eliminarAnalisis;
    }
}