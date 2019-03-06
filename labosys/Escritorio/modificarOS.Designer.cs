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
            this.gbx_modificar = new System.Windows.Forms.GroupBox();
            this.txt_arancel = new System.Windows.Forms.TextBox();
            this.lbl_arancel = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.rbt_NBU = new System.Windows.Forms.RadioButton();
            this.rbt_Inos = new System.Windows.Forms.RadioButton();
            this.btn_ModificarOS = new System.Windows.Forms.Button();
            this.gbx_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_modificar
            // 
            this.gbx_modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_modificar.Controls.Add(this.rbt_Inos);
            this.gbx_modificar.Controls.Add(this.rbt_NBU);
            this.gbx_modificar.Controls.Add(this.txt_arancel);
            this.gbx_modificar.Controls.Add(this.lbl_arancel);
            this.gbx_modificar.Controls.Add(this.txt_porcentaje);
            this.gbx_modificar.Controls.Add(this.lbl_porcentaje);
            this.gbx_modificar.Controls.Add(this.txt_nombre);
            this.gbx_modificar.Controls.Add(this.lbl_nombre);
            this.gbx_modificar.Location = new System.Drawing.Point(83, 51);
            this.gbx_modificar.Name = "gbx_modificar";
            this.gbx_modificar.Size = new System.Drawing.Size(323, 224);
            this.gbx_modificar.TabIndex = 10;
            this.gbx_modificar.TabStop = false;
            this.gbx_modificar.Text = "Obra Social existente";
            // 
            // txt_arancel
            // 
            this.txt_arancel.Location = new System.Drawing.Point(140, 169);
            this.txt_arancel.Name = "txt_arancel";
            this.txt_arancel.Size = new System.Drawing.Size(100, 20);
            this.txt_arancel.TabIndex = 5;
            // 
            // lbl_arancel
            // 
            this.lbl_arancel.AutoSize = true;
            this.lbl_arancel.Location = new System.Drawing.Point(46, 176);
            this.lbl_arancel.Name = "lbl_arancel";
            this.lbl_arancel.Size = new System.Drawing.Size(43, 13);
            this.lbl_arancel.TabIndex = 4;
            this.lbl_arancel.Text = "Arancel";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(140, 94);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(100, 20);
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
            // rbt_NBU
            // 
            this.rbt_NBU.AutoSize = true;
            this.rbt_NBU.Location = new System.Drawing.Point(140, 133);
            this.rbt_NBU.Name = "rbt_NBU";
            this.rbt_NBU.Size = new System.Drawing.Size(48, 17);
            this.rbt_NBU.TabIndex = 6;
            this.rbt_NBU.TabStop = true;
            this.rbt_NBU.Text = "NBU";
            this.rbt_NBU.UseVisualStyleBackColor = true;
            // 
            // rbt_Inos
            // 
            this.rbt_Inos.AutoSize = true;
            this.rbt_Inos.Location = new System.Drawing.Point(194, 133);
            this.rbt_Inos.Name = "rbt_Inos";
            this.rbt_Inos.Size = new System.Drawing.Size(51, 17);
            this.rbt_Inos.TabIndex = 7;
            this.rbt_Inos.TabStop = true;
            this.rbt_Inos.Text = "INOS";
            this.rbt_Inos.UseVisualStyleBackColor = true;
            // 
            // btn_ModificarOS
            // 
            this.btn_ModificarOS.Location = new System.Drawing.Point(223, 292);
            this.btn_ModificarOS.Name = "btn_ModificarOS";
            this.btn_ModificarOS.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarOS.TabIndex = 11;
            this.btn_ModificarOS.Text = "Modificar";
            this.btn_ModificarOS.UseVisualStyleBackColor = true;
            this.btn_ModificarOS.Click += new System.EventHandler(this.btn_ModificarOS_Click);
            // 
            // modificarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.btn_ModificarOS);
            this.Controls.Add(this.gbx_modificar);
            this.Name = "modificarOS";
            this.Text = "modificarOS";
            this.gbx_modificar.ResumeLayout(false);
            this.gbx_modificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_modificar;
        private System.Windows.Forms.TextBox txt_arancel;
        private System.Windows.Forms.Label lbl_arancel;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.RadioButton rbt_Inos;
        private System.Windows.Forms.RadioButton rbt_NBU;
        private System.Windows.Forms.Button btn_ModificarOS;
    }
}