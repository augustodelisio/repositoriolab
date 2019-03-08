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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_analisis
            // 
            this.dgv_analisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analisis.Location = new System.Drawing.Point(36, 30);
            this.dgv_analisis.Name = "dgv_analisis";
            this.dgv_analisis.Size = new System.Drawing.Size(513, 168);
            this.dgv_analisis.TabIndex = 0;
            // 
            // AnalisisExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.dgv_analisis);
            this.Name = "AnalisisExamen";
            this.Text = "AnalisisExamen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analisis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_analisis;
    }
}