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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altaObraSocial));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_nbu = new System.Windows.Forms.Label();
            this.txt_nbu = new System.Windows.Forms.TextBox();
            this.btn_agregarobrasocial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_actoBioquimico = new System.Windows.Forms.Label();
            this.txt_actoBioquimico = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_atras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(79, 34);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(58, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(160, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(155, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcentaje.Location = new System.Drawing.Point(65, 88);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(76, 15);
            this.lbl_porcentaje.TabIndex = 2;
            this.lbl_porcentaje.Text = "Porcentaje";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(160, 85);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(155, 23);
            this.txt_porcentaje.TabIndex = 3;
            this.txt_porcentaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_porcentaje_KeyUp);
            this.txt_porcentaje.Leave += new System.EventHandler(this.txt_porcentaje_Leave);
            // 
            // lbl_nbu
            // 
            this.lbl_nbu.AutoSize = true;
            this.lbl_nbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbu.Location = new System.Drawing.Point(104, 141);
            this.lbl_nbu.Name = "lbl_nbu";
            this.lbl_nbu.Size = new System.Drawing.Size(33, 15);
            this.lbl_nbu.TabIndex = 4;
            this.lbl_nbu.Text = "Nbu";
            // 
            // txt_nbu
            // 
            this.txt_nbu.Location = new System.Drawing.Point(160, 138);
            this.txt_nbu.Name = "txt_nbu";
            this.txt_nbu.Size = new System.Drawing.Size(155, 23);
            this.txt_nbu.TabIndex = 5;
            this.txt_nbu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nbu_KeyUp);
            // 
            // btn_agregarobrasocial
            // 
            this.btn_agregarobrasocial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregarobrasocial.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarobrasocial.Location = new System.Drawing.Point(189, 345);
            this.btn_agregarobrasocial.Name = "btn_agregarobrasocial";
            this.btn_agregarobrasocial.Size = new System.Drawing.Size(130, 30);
            this.btn_agregarobrasocial.TabIndex = 6;
            this.btn_agregarobrasocial.Text = "Agregar";
            this.btn_agregarobrasocial.UseVisualStyleBackColor = false;
            this.btn_agregarobrasocial.Click += new System.EventHandler(this.btn_agregarobrasocial_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_actoBioquimico);
            this.groupBox1.Controls.Add(this.txt_actoBioquimico);
            this.groupBox1.Controls.Add(this.txt_nbu);
            this.groupBox1.Controls.Add(this.lbl_nbu);
            this.groupBox1.Controls.Add(this.txt_porcentaje);
            this.groupBox1.Controls.Add(this.lbl_porcentaje);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Obra Social";
            // 
            // lbl_actoBioquimico
            // 
            this.lbl_actoBioquimico.AutoSize = true;
            this.lbl_actoBioquimico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actoBioquimico.Location = new System.Drawing.Point(31, 194);
            this.lbl_actoBioquimico.Name = "lbl_actoBioquimico";
            this.lbl_actoBioquimico.Size = new System.Drawing.Size(110, 15);
            this.lbl_actoBioquimico.TabIndex = 7;
            this.lbl_actoBioquimico.Text = "Acto Bioquimico";
            // 
            // txt_actoBioquimico
            // 
            this.txt_actoBioquimico.Location = new System.Drawing.Point(160, 191);
            this.txt_actoBioquimico.Name = "txt_actoBioquimico";
            this.txt_actoBioquimico.Size = new System.Drawing.Size(155, 23);
            this.txt_actoBioquimico.TabIndex = 6;
            this.txt_actoBioquimico.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_actoBioquimico_KeyUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // altaObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregarobrasocial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "altaObraSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Obra Social";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lbl_nbu;
        private System.Windows.Forms.TextBox txt_nbu;
        private System.Windows.Forms.Button btn_agregarobrasocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_actoBioquimico;
        private System.Windows.Forms.TextBox txt_actoBioquimico;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_atras;
    }
}