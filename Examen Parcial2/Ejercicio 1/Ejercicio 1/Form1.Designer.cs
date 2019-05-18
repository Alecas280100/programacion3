namespace Ejercicio_1
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
            this.btnobtenercoti = new System.Windows.Forms.Button();
            this.btncolocarcoti = new System.Windows.Forms.Button();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.txtobtener = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnobtenercoti
            // 
            this.btnobtenercoti.Location = new System.Drawing.Point(323, 101);
            this.btnobtenercoti.Name = "btnobtenercoti";
            this.btnobtenercoti.Size = new System.Drawing.Size(127, 23);
            this.btnobtenercoti.TabIndex = 0;
            this.btnobtenercoti.Text = "obtener cotizacion";
            this.btnobtenercoti.UseVisualStyleBackColor = true;
            this.btnobtenercoti.Click += new System.EventHandler(this.btnobtenercoti_Click);
            // 
            // btncolocarcoti
            // 
            this.btncolocarcoti.Location = new System.Drawing.Point(323, 144);
            this.btncolocarcoti.Name = "btncolocarcoti";
            this.btncolocarcoti.Size = new System.Drawing.Size(127, 23);
            this.btncolocarcoti.TabIndex = 1;
            this.btncolocarcoti.Text = "colocar cotizacion";
            this.btncolocarcoti.UseVisualStyleBackColor = true;
            this.btncolocarcoti.Click += new System.EventHandler(this.btncolocarcoti_Click);
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Location = new System.Drawing.Point(375, 207);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(10, 13);
            this.lblmostrar.TabIndex = 2;
            this.lblmostrar.Text = "-";
            this.lblmostrar.Click += new System.EventHandler(this.lblmostrar_Click);
            // 
            // txtobtener
            // 
            this.txtobtener.Location = new System.Drawing.Point(182, 101);
            this.txtobtener.Name = "txtobtener";
            this.txtobtener.Size = new System.Drawing.Size(100, 20);
            this.txtobtener.TabIndex = 3;
            this.txtobtener.Text = " ";
            this.txtobtener.TextChanged += new System.EventHandler(this.txtobtener_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtobtener);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.btncolocarcoti);
            this.Controls.Add(this.btnobtenercoti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnobtenercoti;
        private System.Windows.Forms.Button btncolocarcoti;
        private System.Windows.Forms.Label lblmostrar;
        private System.Windows.Forms.TextBox txtobtener;
    }
}

