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
            System.Windows.Forms.GroupBox gbx_filtrarOS;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMObraSocial));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dgv_obrasSociales = new System.Windows.Forms.DataGridView();
            this.btn_altaobrasocial = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_modificarOS = new System.Windows.Forms.Button();
            this.btn_habilitarOS = new System.Windows.Forms.Button();
            this.btn_deshabilitarOS = new System.Windows.Forms.Button();
            gbx_filtrarOS = new System.Windows.Forms.GroupBox();
            gbx_filtrarOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_filtrarOS
            // 
            gbx_filtrarOS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            gbx_filtrarOS.Controls.Add(this.txt_nombre);
            gbx_filtrarOS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbx_filtrarOS.Location = new System.Drawing.Point(12, 331);
            gbx_filtrarOS.Name = "gbx_filtrarOS";
            gbx_filtrarOS.Size = new System.Drawing.Size(257, 55);
            gbx_filtrarOS.TabIndex = 12;
            gbx_filtrarOS.TabStop = false;
            gbx_filtrarOS.Text = "Filtrar por Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(44, 22);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(188, 23);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // dgv_obrasSociales
            // 
            this.dgv_obrasSociales.AllowUserToAddRows = false;
            this.dgv_obrasSociales.AllowUserToDeleteRows = false;
            this.dgv_obrasSociales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_obrasSociales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_obrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_obrasSociales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_obrasSociales.Location = new System.Drawing.Point(12, 12);
            this.dgv_obrasSociales.MultiSelect = false;
            this.dgv_obrasSociales.Name = "dgv_obrasSociales";
            this.dgv_obrasSociales.ReadOnly = true;
            this.dgv_obrasSociales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_obrasSociales.Size = new System.Drawing.Size(563, 306);
            this.dgv_obrasSociales.TabIndex = 6;
            this.dgv_obrasSociales.CurrentCellChanged += new System.EventHandler(this.dgv_obrasSociales_CurrentCellChanged);
            this.dgv_obrasSociales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_obrasSociales_DataBindingComplete);
            // 
            // btn_altaobrasocial
            // 
            this.btn_altaobrasocial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_altaobrasocial.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altaobrasocial.Location = new System.Drawing.Point(395, 415);
            this.btn_altaobrasocial.Name = "btn_altaobrasocial";
            this.btn_altaobrasocial.Size = new System.Drawing.Size(180, 35);
            this.btn_altaobrasocial.TabIndex = 7;
            this.btn_altaobrasocial.Text = "Nueva Obra Social";
            this.btn_altaobrasocial.UseVisualStyleBackColor = false;
            this.btn_altaobrasocial.Click += new System.EventHandler(this.Btn_altaobrasocial_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(12, 519);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 30);
            this.btn_atras.TabIndex = 8;
            this.btn_atras.Text = "Volver";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_modificarOS
            // 
            this.btn_modificarOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_modificarOS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarOS.Location = new System.Drawing.Point(395, 456);
            this.btn_modificarOS.Name = "btn_modificarOS";
            this.btn_modificarOS.Size = new System.Drawing.Size(180, 35);
            this.btn_modificarOS.TabIndex = 9;
            this.btn_modificarOS.Text = "Modificar OS";
            this.btn_modificarOS.UseVisualStyleBackColor = false;
            this.btn_modificarOS.Click += new System.EventHandler(this.btn_modificarOS_Click);
            // 
            // btn_habilitarOS
            // 
            this.btn_habilitarOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_habilitarOS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitarOS.Location = new System.Drawing.Point(490, 331);
            this.btn_habilitarOS.Name = "btn_habilitarOS";
            this.btn_habilitarOS.Size = new System.Drawing.Size(85, 35);
            this.btn_habilitarOS.TabIndex = 10;
            this.btn_habilitarOS.Text = "Habilitar";
            this.btn_habilitarOS.UseVisualStyleBackColor = false;
            this.btn_habilitarOS.Click += new System.EventHandler(this.btn_habilitarOS_Click);
            // 
            // btn_deshabilitarOS
            // 
            this.btn_deshabilitarOS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deshabilitarOS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deshabilitarOS.Location = new System.Drawing.Point(490, 331);
            this.btn_deshabilitarOS.Name = "btn_deshabilitarOS";
            this.btn_deshabilitarOS.Size = new System.Drawing.Size(85, 35);
            this.btn_deshabilitarOS.TabIndex = 11;
            this.btn_deshabilitarOS.Text = "Deshabilitar";
            this.btn_deshabilitarOS.UseVisualStyleBackColor = false;
            this.btn_deshabilitarOS.Click += new System.EventHandler(this.btn_deshabilitarOS_Click);
            // 
            // ABMObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(gbx_filtrarOS);
            this.Controls.Add(this.btn_deshabilitarOS);
            this.Controls.Add(this.btn_habilitarOS);
            this.Controls.Add(this.btn_modificarOS);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_altaobrasocial);
            this.Controls.Add(this.dgv_obrasSociales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMObraSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Obra Social";
            gbx_filtrarOS.ResumeLayout(false);
            gbx_filtrarOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_obrasSociales;
        private System.Windows.Forms.Button btn_altaobrasocial;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_modificarOS;
        private System.Windows.Forms.Button btn_habilitarOS;
        private System.Windows.Forms.Button btn_deshabilitarOS;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}