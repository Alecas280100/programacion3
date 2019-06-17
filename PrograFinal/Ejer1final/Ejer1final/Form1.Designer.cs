namespace Ejer1final
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.lblmostrar = new System.Windows.Forms.ListBox();
            this.btbmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(409, 130);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.Text = "registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(250, 130);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 20);
            this.txtplaca.TabIndex = 1;
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(250, 206);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 3;
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(250, 242);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(100, 20);
            this.txtingreso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "tipo de vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto a cobrar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora de ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora de salida";
            // 
            // txtsalida
            // 
            this.txtsalida.Location = new System.Drawing.Point(250, 277);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(100, 20);
            this.txtsalida.TabIndex = 10;
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Items.AddRange(new object[] {
            "auto",
            "vagoneta",
            "moto",
            "camion",
            "jeep",
            "otros"});
            this.combotipo.Location = new System.Drawing.Point(250, 170);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(121, 21);
            this.combotipo.TabIndex = 11;
            // 
            // lblmostrar
            // 
            this.lblmostrar.FormattingEnabled = true;
            this.lblmostrar.Location = new System.Drawing.Point(443, 188);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(303, 251);
            this.lblmostrar.TabIndex = 12;
            // 
            // btbmostrar
            // 
            this.btbmostrar.Location = new System.Drawing.Point(409, 101);
            this.btbmostrar.Name = "btbmostrar";
            this.btbmostrar.Size = new System.Drawing.Size(75, 23);
            this.btbmostrar.TabIndex = 13;
            this.btbmostrar.Text = "mostrar";
            this.btbmostrar.UseVisualStyleBackColor = true;
            this.btbmostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 501);
            this.Controls.Add(this.btbmostrar);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.btnregistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.ListBox lblmostrar;
        private System.Windows.Forms.Button btbmostrar;
    }
}

