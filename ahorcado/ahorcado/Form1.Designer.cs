namespace ahorcado
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
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnempezar = new System.Windows.Forms.Button();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnenviarpalabra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(208, 199);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(10, 13);
            this.lblrespuesta.TabIndex = 0;
            this.lblrespuesta.Text = "-";
            // 
            // btnempezar
            // 
            this.btnempezar.Location = new System.Drawing.Point(554, 79);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(75, 23);
            this.btnempezar.TabIndex = 1;
            this.btnempezar.Text = "Empezar";
            this.btnempezar.UseVisualStyleBackColor = true;
            this.btnempezar.Click += new System.EventHandler(this.btnempezar_Click);
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.Location = new System.Drawing.Point(323, 84);
            this.txtrespuesta.MaxLength = 1;
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(45, 20);
            this.txtrespuesta.TabIndex = 2;
            this.txtrespuesta.TextChanged += new System.EventHandler(this.txtrespuesta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduzca una letra";
            // 
            // pbimagen
            // 
            this.pbimagen.Location = new System.Drawing.Point(306, 199);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(201, 209);
            this.pbimagen.TabIndex = 4;
            this.pbimagen.TabStop = false;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(554, 116);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 5;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palabra Adivinar";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(323, 126);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra.TabIndex = 7;
            this.txtPalabra.TextChanged += new System.EventHandler(this.txtPalabra_TextChanged);
            // 
            // btnenviarpalabra
            // 
            this.btnenviarpalabra.Location = new System.Drawing.Point(554, 145);
            this.btnenviarpalabra.Name = "btnenviarpalabra";
            this.btnenviarpalabra.Size = new System.Drawing.Size(108, 23);
            this.btnenviarpalabra.TabIndex = 8;
            this.btnenviarpalabra.Text = "Enviar palabra";
            this.btnenviarpalabra.UseVisualStyleBackColor = true;
            this.btnenviarpalabra.Click += new System.EventHandler(this.btnenviarpalabra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 594);
            this.Controls.Add(this.btnenviarpalabra);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.pbimagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrespuesta);
            this.Controls.Add(this.btnempezar);
            this.Controls.Add(this.lblrespuesta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnempezar;
        private System.Windows.Forms.TextBox txtrespuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbimagen;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnenviarpalabra;
    }
}

