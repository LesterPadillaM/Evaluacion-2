
namespace Evaluacion_2
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 23);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(89, 49);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(100, 20);
            this.txtcuenta.TabIndex = 3;
            this.txtcuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuenta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. de Cuenta";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(89, 75);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 5;
            this.txtnota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 1";
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(89, 101);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 7;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 2";
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(89, 127);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 9;
            this.txtnota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 3";
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(89, 153);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 20);
            this.txtnota4.TabIndex = 11;
            this.txtnota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnota4_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota 4";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(219, 101);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(111, 53);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular ";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(219, 33);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(111, 50);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 191);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Evaluacion 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

