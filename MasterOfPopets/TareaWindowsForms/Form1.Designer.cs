namespace TareaWindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btbMostrar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnNumeric = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRespuesta = new System.Windows.Forms.NumericUpDown();
            this.lblRespuesta2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRespuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(216, 45);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 1;
            // 
            // btbMostrar
            // 
            this.btbMostrar.Location = new System.Drawing.Point(450, 41);
            this.btbMostrar.Name = "btbMostrar";
            this.btbMostrar.Size = new System.Drawing.Size(75, 23);
            this.btbMostrar.TabIndex = 2;
            this.btbMostrar.Text = "Cargue";
            this.btbMostrar.UseVisualStyleBackColor = true;
            this.btbMostrar.Click += new System.EventHandler(this.btbMostrar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(79, 144);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta.TabIndex = 3;
            // 
            // btnNumeric
            // 
            this.btnNumeric.Location = new System.Drawing.Point(450, 173);
            this.btnNumeric.Name = "btnNumeric";
            this.btnNumeric.Size = new System.Drawing.Size(75, 23);
            this.btnNumeric.TabIndex = 6;
            this.btnNumeric.Text = "Numeric";
            this.btnNumeric.UseVisualStyleBackColor = true;
            this.btnNumeric.Click += new System.EventHandler(this.btnNumeric_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // nudRespuesta
            // 
            this.nudRespuesta.Location = new System.Drawing.Point(216, 177);
            this.nudRespuesta.Name = "nudRespuesta";
            this.nudRespuesta.Size = new System.Drawing.Size(120, 20);
            this.nudRespuesta.TabIndex = 7;
            // 
            // lblRespuesta2
            // 
            this.lblRespuesta2.AutoSize = true;
            this.lblRespuesta2.Location = new System.Drawing.Point(82, 266);
            this.lblRespuesta2.Name = "lblRespuesta2";
            this.lblRespuesta2.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta2.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(609, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(216, 275);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha :";
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(474, 272);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 12;
            this.btnFecha.Text = "Cargue";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(82, 345);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblRespuesta2);
            this.Controls.Add(this.nudRespuesta);
            this.Controls.Add(this.btnNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btbMostrar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRespuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btbMostrar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRespuesta;
        private System.Windows.Forms.Label lblRespuesta2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}

