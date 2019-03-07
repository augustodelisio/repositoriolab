namespace Escritorio
{
    partial class altaObraSocial
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_arancel = new System.Windows.Forms.Label();
            this.txt_arancel = new System.Windows.Forms.TextBox();
            this.btn_agregarobrasocial = new System.Windows.Forms.Button();
            this.rbt_nbu = new System.Windows.Forms.RadioButton();
            this.rbt_inos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(79, 34);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(160, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(117, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(65, 92);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(58, 13);
            this.lbl_porcentaje.TabIndex = 2;
            this.lbl_porcentaje.Text = "Porcentaje";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(160, 89);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(117, 20);
            this.txt_porcentaje.TabIndex = 3;
            // 
            // lbl_arancel
            // 
            this.lbl_arancel.AutoSize = true;
            this.lbl_arancel.Location = new System.Drawing.Point(80, 183);
            this.lbl_arancel.Name = "lbl_arancel";
            this.lbl_arancel.Size = new System.Drawing.Size(43, 13);
            this.lbl_arancel.TabIndex = 4;
            this.lbl_arancel.Text = "Arancel";
            // 
            // txt_arancel
            // 
            this.txt_arancel.Location = new System.Drawing.Point(160, 180);
            this.txt_arancel.Name = "txt_arancel";
            this.txt_arancel.Size = new System.Drawing.Size(117, 20);
            this.txt_arancel.TabIndex = 5;
            // 
            // btn_agregarobrasocial
            // 
            this.btn_agregarobrasocial.Location = new System.Drawing.Point(220, 284);
            this.btn_agregarobrasocial.Name = "btn_agregarobrasocial";
            this.btn_agregarobrasocial.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarobrasocial.TabIndex = 6;
            this.btn_agregarobrasocial.Text = "Agregar";
            this.btn_agregarobrasocial.UseVisualStyleBackColor = true;
            this.btn_agregarobrasocial.Click += new System.EventHandler(this.btn_agregarobrasocial_Click);
            // 
            // rbt_nbu
            // 
            this.rbt_nbu.AutoSize = true;
            this.rbt_nbu.Checked = true;
            this.rbt_nbu.Location = new System.Drawing.Point(160, 134);
            this.rbt_nbu.Name = "rbt_nbu";
            this.rbt_nbu.Size = new System.Drawing.Size(48, 17);
            this.rbt_nbu.TabIndex = 7;
            this.rbt_nbu.TabStop = true;
            this.rbt_nbu.Text = "NBU";
            this.rbt_nbu.UseVisualStyleBackColor = true;
            this.rbt_nbu.CheckedChanged += new System.EventHandler(this.rbt_nbu_CheckedChanged);
            // 
            // rbt_inos
            // 
            this.rbt_inos.AutoSize = true;
            this.rbt_inos.Location = new System.Drawing.Point(226, 134);
            this.rbt_inos.Name = "rbt_inos";
            this.rbt_inos.Size = new System.Drawing.Size(51, 17);
            this.rbt_inos.TabIndex = 8;
            this.rbt_inos.TabStop = true;
            this.rbt_inos.Text = "INOS";
            this.rbt_inos.UseVisualStyleBackColor = true;
            this.rbt_inos.CheckedChanged += new System.EventHandler(this.rbt_inos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_inos);
            this.groupBox1.Controls.Add(this.rbt_nbu);
            this.groupBox1.Controls.Add(this.txt_arancel);
            this.groupBox1.Controls.Add(this.lbl_arancel);
            this.groupBox1.Controls.Add(this.txt_porcentaje);
            this.groupBox1.Controls.Add(this.lbl_porcentaje);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Location = new System.Drawing.Point(60, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Obra Social";
            // 
            // altaObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregarobrasocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "altaObraSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Obra Social";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lbl_arancel;
        private System.Windows.Forms.TextBox txt_arancel;
        private System.Windows.Forms.Button btn_agregarobrasocial;
        private System.Windows.Forms.RadioButton rbt_nbu;
        private System.Windows.Forms.RadioButton rbt_inos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}