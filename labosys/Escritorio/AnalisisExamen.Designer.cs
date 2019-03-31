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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalisisExamen));
            this.dgv_analisis = new System.Windows.Forms.DataGridView();
            this.btn_agregarAnalisis = new System.Windows.Forms.Button();
            this.cmb_analisis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombreAnalisis = new System.Windows.Forms.Label();
            this.btn_guardarCambios = new System.Windows.Forms.Button();
            this.btn_eliminarAnalisis = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_analisis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_analisis.Location = new System.Drawing.Point(21, 25);
            this.dgv_analisis.MultiSelect = false;
            this.dgv_analisis.Name = "dgv_analisis";
            this.dgv_analisis.ReadOnly = true;
            this.dgv_analisis.Size = new System.Drawing.Size(534, 168);
            this.dgv_analisis.TabIndex = 2;
            // 
            // btn_agregarAnalisis
            // 
            this.btn_agregarAnalisis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregarAnalisis.Location = new System.Drawing.Point(25, 25);
            this.btn_agregarAnalisis.Name = "btn_agregarAnalisis";
            this.btn_agregarAnalisis.Size = new System.Drawing.Size(130, 30);
            this.btn_agregarAnalisis.TabIndex = 1;
            this.btn_agregarAnalisis.Text = "Agregar Analisis";
            this.btn_agregarAnalisis.UseVisualStyleBackColor = false;
            this.btn_agregarAnalisis.Click += new System.EventHandler(this.btn_agregarAnalisis_Click);
            this.btn_agregarAnalisis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_agregarAnalisis_KeyUp);
            // 
            // cmb_analisis
            // 
            this.cmb_analisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_analisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_analisis.CausesValidation = false;
            this.cmb_analisis.FormattingEnabled = true;
            this.cmb_analisis.Location = new System.Drawing.Point(193, 25);
            this.cmb_analisis.Name = "cmb_analisis";
            this.cmb_analisis.Size = new System.Drawing.Size(216, 25);
            this.cmb_analisis.TabIndex = 0;
            this.cmb_analisis.SelectedValueChanged += new System.EventHandler(this.cmb_analisis_SelectedValueChanged);
            this.cmb_analisis.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_analisis_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_nombreAnalisis);
            this.groupBox1.Controls.Add(this.cmb_analisis);
            this.groupBox1.Controls.Add(this.btn_agregarAnalisis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Analisis";
            // 
            // lbl_nombreAnalisis
            // 
            this.lbl_nombreAnalisis.AutoSize = true;
            this.lbl_nombreAnalisis.Location = new System.Drawing.Point(193, 53);
            this.lbl_nombreAnalisis.Name = "lbl_nombreAnalisis";
            this.lbl_nombreAnalisis.Size = new System.Drawing.Size(43, 17);
            this.lbl_nombreAnalisis.TabIndex = 3;
            this.lbl_nombreAnalisis.Text = "label1";
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_guardarCambios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarCambios.Location = new System.Drawing.Point(208, 346);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.Size = new System.Drawing.Size(180, 40);
            this.btn_guardarCambios.TabIndex = 4;
            this.btn_guardarCambios.Text = "Guardar Cambios";
            this.btn_guardarCambios.UseVisualStyleBackColor = false;
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
            // 
            // btn_eliminarAnalisis
            // 
            this.btn_eliminarAnalisis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_eliminarAnalisis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarAnalisis.Location = new System.Drawing.Point(233, 301);
            this.btn_eliminarAnalisis.Name = "btn_eliminarAnalisis";
            this.btn_eliminarAnalisis.Size = new System.Drawing.Size(130, 30);
            this.btn_eliminarAnalisis.TabIndex = 5;
            this.btn_eliminarAnalisis.Text = "Eliminar Analisis";
            this.btn_eliminarAnalisis.UseVisualStyleBackColor = false;
            this.btn_eliminarAnalisis.Click += new System.EventHandler(this.btn_eliminarAnalisis_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 419);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 19;
            this.btn_atras.Text = "Volver";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Nuevo Analisis";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnalisisExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_eliminarAnalisis);
            this.Controls.Add(this.btn_guardarCambios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_analisis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalisisExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Analisis al Examen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnalisisExamen_FormClosing);
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
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button button1;
    }
}