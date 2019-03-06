namespace Escritorio
{
    partial class ABMObraSocial
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
            this.dgv_obrasSociales = new System.Windows.Forms.DataGridView();
            this.btn_altaobrasocial = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_modificarOS = new System.Windows.Forms.Button();
            this.btn_habilitarOS = new System.Windows.Forms.Button();
            this.btn_deshabilitarOS = new System.Windows.Forms.Button();
            this.gbx_filtrarOS = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).BeginInit();
            this.gbx_filtrarOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_obrasSociales
            // 
            this.dgv_obrasSociales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_obrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_obrasSociales.Location = new System.Drawing.Point(12, 12);
            this.dgv_obrasSociales.Name = "dgv_obrasSociales";
            this.dgv_obrasSociales.ReadOnly = true;
            this.dgv_obrasSociales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_obrasSociales.Size = new System.Drawing.Size(563, 306);
            this.dgv_obrasSociales.TabIndex = 6;
            this.dgv_obrasSociales.CurrentCellChanged += new System.EventHandler(this.dgv_obrasSociales_CurrentCellChanged);
            // 
            // btn_altaobrasocial
            // 
            this.btn_altaobrasocial.Location = new System.Drawing.Point(368, 351);
            this.btn_altaobrasocial.Name = "btn_altaobrasocial";
            this.btn_altaobrasocial.Size = new System.Drawing.Size(146, 34);
            this.btn_altaobrasocial.TabIndex = 7;
            this.btn_altaobrasocial.Text = "Alta OS";
            this.btn_altaobrasocial.UseVisualStyleBackColor = true;
            this.btn_altaobrasocial.Click += new System.EventHandler(this.Btn_altaobrasocial_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(54, 479);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(132, 32);
            this.btn_atras.TabIndex = 8;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_modificarOS
            // 
            this.btn_modificarOS.Location = new System.Drawing.Point(368, 391);
            this.btn_modificarOS.Name = "btn_modificarOS";
            this.btn_modificarOS.Size = new System.Drawing.Size(146, 34);
            this.btn_modificarOS.TabIndex = 9;
            this.btn_modificarOS.Text = "Modificar OS";
            this.btn_modificarOS.UseVisualStyleBackColor = true;
            this.btn_modificarOS.Click += new System.EventHandler(this.btn_modificarOS_Click);
            // 
            // btn_habilitarOS
            // 
            this.btn_habilitarOS.Location = new System.Drawing.Point(368, 431);
            this.btn_habilitarOS.Name = "btn_habilitarOS";
            this.btn_habilitarOS.Size = new System.Drawing.Size(146, 34);
            this.btn_habilitarOS.TabIndex = 10;
            this.btn_habilitarOS.Text = "Habilitar";
            this.btn_habilitarOS.UseVisualStyleBackColor = true;
            this.btn_habilitarOS.Click += new System.EventHandler(this.btn_habilitarOS_Click);
            // 
            // btn_deshabilitarOS
            // 
            this.btn_deshabilitarOS.Location = new System.Drawing.Point(368, 431);
            this.btn_deshabilitarOS.Name = "btn_deshabilitarOS";
            this.btn_deshabilitarOS.Size = new System.Drawing.Size(146, 34);
            this.btn_deshabilitarOS.TabIndex = 11;
            this.btn_deshabilitarOS.Text = "Deshabilitar";
            this.btn_deshabilitarOS.UseVisualStyleBackColor = true;
            this.btn_deshabilitarOS.Click += new System.EventHandler(this.btn_deshabilitarOS_Click);
            // 
            // gbx_filtrarOS
            // 
            this.gbx_filtrarOS.Controls.Add(this.lbl_nombre);
            this.gbx_filtrarOS.Controls.Add(this.txt_nombre);
            this.gbx_filtrarOS.Location = new System.Drawing.Point(12, 351);
            this.gbx_filtrarOS.Name = "gbx_filtrarOS";
            this.gbx_filtrarOS.Size = new System.Drawing.Size(229, 54);
            this.gbx_filtrarOS.TabIndex = 12;
            this.gbx_filtrarOS.TabStop = false;
            this.gbx_filtrarOS.Text = "Filtrar por nombre";
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
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(78, 22);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(130, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // ABMObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 540);
            this.Controls.Add(this.gbx_filtrarOS);
            this.Controls.Add(this.btn_deshabilitarOS);
            this.Controls.Add(this.btn_habilitarOS);
            this.Controls.Add(this.btn_modificarOS);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_altaobrasocial);
            this.Controls.Add(this.dgv_obrasSociales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ABMObraSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMObraSocial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).EndInit();
            this.gbx_filtrarOS.ResumeLayout(false);
            this.gbx_filtrarOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_obrasSociales;
        private System.Windows.Forms.Button btn_altaobrasocial;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_modificarOS;
        private System.Windows.Forms.Button btn_habilitarOS;
        private System.Windows.Forms.Button btn_deshabilitarOS;
        private System.Windows.Forms.GroupBox gbx_filtrarOS;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}