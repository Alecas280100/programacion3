namespace Ejercicio_3_Cliente
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
            this.btnempezar = new System.Windows.Forms.Button();
            this.btnletra = new System.Windows.Forms.Button();
            this.btnpalabra = new System.Windows.Forms.Button();
            this.txtletra = new System.Windows.Forms.TextBox();
            this.txtpalabraadivinar = new System.Windows.Forms.TextBox();
            this.lblIntroduzcaLetra = new System.Windows.Forms.Label();
            this.lblPalabraAdivinar = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnempezar
            // 
            this.btnempezar.Location = new System.Drawing.Point(404, 46);
            this.btnempezar.Name = "btnempezar";
            this.btnempezar.Size = new System.Drawing.Size(75, 23);
            this.btnempezar.TabIndex = 0;
            this.btnempezar.Text = "Empezar";
            this.btnempezar.UseVisualStyleBackColor = true;
            this.btnempezar.Click += new System.EventHandler(this.btnempezar_Click);
            // 
            // btnletra
            // 
            this.btnletra.Location = new System.Drawing.Point(404, 91);
            this.btnletra.Name = "btnletra";
            this.btnletra.Size = new System.Drawing.Size(75, 23);
            this.btnletra.TabIndex = 1;
            this.btnletra.Text = "Enviar Letra";
            this.btnletra.UseVisualStyleBackColor = true;
            // 
            // btnpalabra
            // 
            this.btnpalabra.Location = new System.Drawing.Point(404, 139);
            this.btnpalabra.Name = "btnpalabra";
            this.btnpalabra.Size = new System.Drawing.Size(75, 23);
            this.btnpalabra.TabIndex = 2;
            this.btnpalabra.Text = "Enviar Palabra";
            this.btnpalabra.UseVisualStyleBackColor = true;
            // 
            // txtletra
            // 
            this.txtletra.Location = new System.Drawing.Point(264, 91);
            this.txtletra.Name = "txtletra";
            this.txtletra.Size = new System.Drawing.Size(39, 20);
            this.txtletra.TabIndex = 3;
            // 
            // txtpalabraadivinar
            // 
            this.txtpalabraadivinar.Location = new System.Drawing.Point(264, 139);
            this.txtpalabraadivinar.Name = "txtpalabraadivinar";
            this.txtpalabraadivinar.Size = new System.Drawing.Size(100, 20);
            this.txtpalabraadivinar.TabIndex = 4;
            // 
            // lblIntroduzcaLetra
            // 
            this.lblIntroduzcaLetra.AutoSize = true;
            this.lblIntroduzcaLetra.Location = new System.Drawing.Point(91, 91);
            this.lblIntroduzcaLetra.Name = "lblIntroduzcaLetra";
            this.lblIntroduzcaLetra.Size = new System.Drawing.Size(84, 13);
            this.lblIntroduzcaLetra.TabIndex = 5;
            this.lblIntroduzcaLetra.Text = "Introduzca Letra";
            // 
            // lblPalabraAdivinar
            // 
            this.lblPalabraAdivinar.AutoSize = true;
            this.lblPalabraAdivinar.Location = new System.Drawing.Point(91, 139);
            this.lblPalabraAdivinar.Name = "lblPalabraAdivinar";
            this.lblPalabraAdivinar.Size = new System.Drawing.Size(84, 13);
            this.lblPalabraAdivinar.TabIndex = 6;
            this.lblPalabraAdivinar.Text = "Palabra Adivinar";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(76, 195);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(10, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "-";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(231, 247);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(176, 166);
            this.pbImagen.TabIndex = 8;
            this.pbImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblPalabraAdivinar);
            this.Controls.Add(this.lblIntroduzcaLetra);
            this.Controls.Add(this.txtpalabraadivinar);
            this.Controls.Add(this.txtletra);
            this.Controls.Add(this.btnpalabra);
            this.Controls.Add(this.btnletra);
            this.Controls.Add(this.btnempezar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnempezar;
        private System.Windows.Forms.Button btnletra;
        private System.Windows.Forms.Button btnpalabra;
        private System.Windows.Forms.TextBox txtletra;
        private System.Windows.Forms.TextBox txtpalabraadivinar;
        private System.Windows.Forms.Label lblIntroduzcaLetra;
        private System.Windows.Forms.Label lblPalabraAdivinar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}

