namespace Escritorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exámenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoExámenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exámenToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.obrasSocialesToolStripMenuItem,
            this.analisisToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exámenToolStripMenuItem
            // 
            this.exámenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoExámenToolStripMenuItem});
            this.exámenToolStripMenuItem.Name = "exámenToolStripMenuItem";
            this.exámenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.exámenToolStripMenuItem.Text = "Exámen";
            // 
            // nuevoExámenToolStripMenuItem
            // 
            this.nuevoExámenToolStripMenuItem.Name = "nuevoExámenToolStripMenuItem";
            this.nuevoExámenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nuevoExámenToolStripMenuItem.Text = "Nuevo exámen";
            this.nuevoExámenToolStripMenuItem.Click += new System.EventHandler(this.nuevoExámenToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDePacientesToolStripMenuItem,
            this.listadoDePacientesToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // gestionDePacientesToolStripMenuItem
            // 
            this.gestionDePacientesToolStripMenuItem.Name = "gestionDePacientesToolStripMenuItem";
            this.gestionDePacientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionDePacientesToolStripMenuItem.Text = "Gestion de Pacientes";
            this.gestionDePacientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDePacientesToolStripMenuItem_Click);
            // 
            // listadoDePacientesToolStripMenuItem
            // 
            this.listadoDePacientesToolStripMenuItem.Name = "listadoDePacientesToolStripMenuItem";
            this.listadoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listadoDePacientesToolStripMenuItem.Text = "Listado de Pacientes";
            this.listadoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDePacientesToolStripMenuItem_Click);
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionObrasSocialesToolStripMenuItem});
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            // 
            // gestionObrasSocialesToolStripMenuItem
            // 
            this.gestionObrasSocialesToolStripMenuItem.Name = "gestionObrasSocialesToolStripMenuItem";
            this.gestionObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gestionObrasSocialesToolStripMenuItem.Text = "Gestion Obras Sociales";
            this.gestionObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.gestionObrasSocialesToolStripMenuItem_Click);
            // 
            // analisisToolStripMenuItem
            // 
            this.analisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionAnalisisToolStripMenuItem});
            this.analisisToolStripMenuItem.Name = "analisisToolStripMenuItem";
            this.analisisToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.analisisToolStripMenuItem.Text = "Analisis";
            // 
            // gestionAnalisisToolStripMenuItem
            // 
            this.gestionAnalisisToolStripMenuItem.Name = "gestionAnalisisToolStripMenuItem";
            this.gestionAnalisisToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.gestionAnalisisToolStripMenuItem.Text = "Gestion Analisis";
            this.gestionAnalisisToolStripMenuItem.Click += new System.EventHandler(this.gestionAnalisisToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bradley Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SP DESARROLLO DE SISTEMAS";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCompletoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteCompletoToolStripMenuItem
            // 
            this.reporteCompletoToolStripMenuItem.Name = "reporteCompletoToolStripMenuItem";
            this.reporteCompletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteCompletoToolStripMenuItem.Text = "Reporte Completo";
            this.reporteCompletoToolStripMenuItem.Click += new System.EventHandler(this.reporteCompletoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionObrasSocialesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem analisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exámenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoExámenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCompletoToolStripMenuItem;
    }
}

