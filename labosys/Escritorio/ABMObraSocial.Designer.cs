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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_obrasSociales
            // 
            this.dgv_obrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_obrasSociales.Location = new System.Drawing.Point(31, 23);
            this.dgv_obrasSociales.Name = "dgv_obrasSociales";
            this.dgv_obrasSociales.Size = new System.Drawing.Size(557, 306);
            this.dgv_obrasSociales.TabIndex = 6;
            // 
            // btn_altaobrasocial
            // 
            this.btn_altaobrasocial.Location = new System.Drawing.Point(675, 56);
            this.btn_altaobrasocial.Name = "btn_altaobrasocial";
            this.btn_altaobrasocial.Size = new System.Drawing.Size(93, 34);
            this.btn_altaobrasocial.TabIndex = 7;
            this.btn_altaobrasocial.Text = "Alta OS";
            this.btn_altaobrasocial.UseVisualStyleBackColor = true;
            this.btn_altaobrasocial.Click += new System.EventHandler(this.Btn_altaobrasocial_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(83, 494);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 41);
            this.btn_atras.TabIndex = 8;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // ABMObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 573);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_altaobrasocial);
            this.Controls.Add(this.dgv_obrasSociales);
            this.Name = "ABMObraSocial";
            this.Text = "ABMObraSocial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_obrasSociales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_obrasSociales;
        private System.Windows.Forms.Button btn_altaobrasocial;
        private System.Windows.Forms.Button btn_atras;
    }
}