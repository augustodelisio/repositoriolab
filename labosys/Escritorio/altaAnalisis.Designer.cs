namespace Escritorio
{
    partial class altaAnalisis
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nbu = new System.Windows.Forms.TextBox();
            this.txt_uh = new System.Windows.Forms.TextBox();
            this.txt_ug = new System.Windows.Forms.TextBox();
            this.lbl_cantNBU = new System.Windows.Forms.Label();
            this.lbl_cantUH = new System.Windows.Forms.Label();
            this.lbl_cantUg = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(264, 360);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txt_nbu);
            this.groupBox1.Controls.Add(this.txt_uh);
            this.groupBox1.Controls.Add(this.txt_ug);
            this.groupBox1.Controls.Add(this.lbl_cantNBU);
            this.groupBox1.Controls.Add(this.lbl_cantUH);
            this.groupBox1.Controls.Add(this.lbl_cantUg);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.lbl_codigo);
            this.groupBox1.Location = new System.Drawing.Point(124, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Analisis";
            // 
            // txt_nbu
            // 
            this.txt_nbu.Location = new System.Drawing.Point(140, 267);
            this.txt_nbu.Name = "txt_nbu";
            this.txt_nbu.Size = new System.Drawing.Size(100, 20);
            this.txt_nbu.TabIndex = 11;
            // 
            // txt_uh
            // 
            this.txt_uh.Location = new System.Drawing.Point(140, 211);
            this.txt_uh.Name = "txt_uh";
            this.txt_uh.Size = new System.Drawing.Size(100, 20);
            this.txt_uh.TabIndex = 10;
            // 
            // txt_ug
            // 
            this.txt_ug.Location = new System.Drawing.Point(140, 155);
            this.txt_ug.Name = "txt_ug";
            this.txt_ug.Size = new System.Drawing.Size(100, 20);
            this.txt_ug.TabIndex = 9;
            // 
            // lbl_cantNBU
            // 
            this.lbl_cantNBU.AutoSize = true;
            this.lbl_cantNBU.Location = new System.Drawing.Point(48, 270);
            this.lbl_cantNBU.Name = "lbl_cantNBU";
            this.lbl_cantNBU.Size = new System.Drawing.Size(75, 13);
            this.lbl_cantNBU.TabIndex = 8;
            this.lbl_cantNBU.Text = "Cantidad NBU";
            // 
            // lbl_cantUH
            // 
            this.lbl_cantUH.AutoSize = true;
            this.lbl_cantUH.Location = new System.Drawing.Point(48, 214);
            this.lbl_cantUH.Name = "lbl_cantUH";
            this.lbl_cantUH.Size = new System.Drawing.Size(68, 13);
            this.lbl_cantUH.TabIndex = 7;
            this.lbl_cantUH.Text = "Cantidad UH";
            // 
            // lbl_cantUg
            // 
            this.lbl_cantUg.AutoSize = true;
            this.lbl_cantUg.Location = new System.Drawing.Point(48, 163);
            this.lbl_cantUg.Name = "lbl_cantUg";
            this.lbl_cantUg.Size = new System.Drawing.Size(68, 13);
            this.lbl_cantUg.TabIndex = 6;
            this.lbl_cantUg.Text = "Cantidad UG";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 94);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(45, 97);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 36);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(45, 39);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Codigo";
            // 
            // altaAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "altaAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Analisis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_cantNBU;
        private System.Windows.Forms.Label lbl_cantUH;
        private System.Windows.Forms.Label lbl_cantUg;
        private System.Windows.Forms.TextBox txt_nbu;
        private System.Windows.Forms.TextBox txt_uh;
        private System.Windows.Forms.TextBox txt_ug;
    }
}