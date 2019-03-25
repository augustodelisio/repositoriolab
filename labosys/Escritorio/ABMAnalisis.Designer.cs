namespace Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMAnalisis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_modificarAnalisis = new System.Windows.Forms.Button();
            this.btn_altaAnalisis = new System.Windows.Forms.Button();
            this.dgv_analisis = new System.Windows.Forms.DataGridView();
            this.btn_atras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 66);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por codigo";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(21, 31);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(52, 17);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_modificarAnalisis
            // 
            this.btn_modificarAnalisis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_modificarAnalisis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarAnalisis.Location = new System.Drawing.Point(366, 403);
            this.btn_modificarAnalisis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_modificarAnalisis.Name = "btn_modificarAnalisis";
            this.btn_modificarAnalisis.Size = new System.Drawing.Size(206, 44);
            this.btn_modificarAnalisis.TabIndex = 15;
            this.btn_modificarAnalisis.Text = "Modificar Analisis";
            this.btn_modificarAnalisis.UseVisualStyleBackColor = false;
            this.btn_modificarAnalisis.Click += new System.EventHandler(this.btn_modificarAnalisis_Click);
            // 
            // btn_altaAnalisis
            // 
            this.btn_altaAnalisis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_altaAnalisis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaAnalisis.Location = new System.Drawing.Point(366, 337);
            this.btn_altaAnalisis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_altaAnalisis.Name = "btn_altaAnalisis";
            this.btn_altaAnalisis.Size = new System.Drawing.Size(206, 42);
            this.btn_altaAnalisis.TabIndex = 13;
            this.btn_altaAnalisis.Text = "Nuevo Analisis";
            this.btn_altaAnalisis.UseVisualStyleBackColor = false;
            this.btn_altaAnalisis.Click += new System.EventHandler(this.btn_altaAnalisis_Click);
            // 
            // dgv_analisis
            // 
            this.dgv_analisis.AllowUserToAddRows = false;
            this.dgv_analisis.AllowUserToDeleteRows = false;
            this.dgv_analisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_analisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analisis.Location = new System.Drawing.Point(14, 15);
            this.dgv_analisis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_analisis.MultiSelect = false;
            this.dgv_analisis.Name = "dgv_analisis";
            this.dgv_analisis.ReadOnly = true;
            this.dgv_analisis.Size = new System.Drawing.Size(558, 306);
            this.dgv_analisis.TabIndex = 12;
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 519);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 17;
            this.btn_atras.Text = "Volver";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // ABMAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_modificarAnalisis);
            this.Controls.Add(this.btn_altaAnalisis);
            this.Controls.Add(this.dgv_analisis);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btn_atras;
    }
}