namespace CalculadoraEconomica
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
            this.txtingresar = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.panltxt = new System.Windows.Forms.Panel();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtinversion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtingresar
            // 
            this.txtingresar.Location = new System.Drawing.Point(83, 38);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(100, 20);
            this.txtingresar.TabIndex = 0;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(206, 34);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // panltxt
            // 
            this.panltxt.Location = new System.Drawing.Point(52, 87);
            this.panltxt.Name = "panltxt";
            this.panltxt.Size = new System.Drawing.Size(175, 332);
            this.panltxt.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(308, 35);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(308, 87);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 4;
            // 
            // txtinversion
            // 
            this.txtinversion.Location = new System.Drawing.Point(308, 128);
            this.txtinversion.Name = "txtinversion";
            this.txtinversion.Size = new System.Drawing.Size(100, 20);
            this.txtinversion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inversion";
            // 
            // lblVAN
            // 
            this.lblVAN.AutoSize = true;
            this.lblVAN.Location = new System.Drawing.Point(258, 167);
            this.lblVAN.Name = "lblVAN";
            this.lblVAN.Size = new System.Drawing.Size(29, 13);
            this.lblVAN.TabIndex = 8;
            this.lblVAN.Text = "VAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinversion);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.panltxt);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtingresar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Panel panltxt;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtinversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVAN;
    }
}

