namespace Practica1
{
    partial class Newton_Raphson
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
            this.label16 = new System.Windows.Forms.Label();
            this.solucion = new System.Windows.Forms.Label();
            this.erelativo = new System.Windows.Forms.Label();
            this.iteraciones = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(304, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(626, 44);
            this.label16.TabIndex = 64;
            this.label16.Text = "METODO DE NEWTON-RAPHSON";
            // 
            // solucion
            // 
            this.solucion.BackColor = System.Drawing.Color.OldLace;
            this.solucion.Location = new System.Drawing.Point(663, 386);
            this.solucion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.solucion.Name = "solucion";
            this.solucion.Size = new System.Drawing.Size(439, 31);
            this.solucion.TabIndex = 62;
            this.solucion.Click += new System.EventHandler(this.Solucion_Click);
            // 
            // erelativo
            // 
            this.erelativo.BackColor = System.Drawing.Color.OldLace;
            this.erelativo.Location = new System.Drawing.Point(819, 292);
            this.erelativo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.erelativo.Name = "erelativo";
            this.erelativo.Size = new System.Drawing.Size(283, 31);
            this.erelativo.TabIndex = 61;
            // 
            // iteraciones
            // 
            this.iteraciones.BackColor = System.Drawing.Color.OldLace;
            this.iteraciones.Location = new System.Drawing.Point(988, 242);
            this.iteraciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.iteraciones.Name = "iteraciones";
            this.iteraciones.Size = new System.Drawing.Size(114, 31);
            this.iteraciones.TabIndex = 60;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(164, 542);
            this.Calcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(206, 50);
            this.Calcular.TabIndex = 58;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGreen;
            this.label10.Location = new System.Drawing.Point(658, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mejor Solución Encontrada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightGreen;
            this.label9.Location = new System.Drawing.Point(658, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Error Relativo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.Location = new System.Drawing.Point(658, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Iteraciones Utilizadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(796, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "DATOS DE SALIDA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(158, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "DATOS DE ENTRADA:";
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(310, 387);
            this.text5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(196, 31);
            this.text5.TabIndex = 52;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(310, 329);
            this.text4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(196, 31);
            this.text4.TabIndex = 51;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(310, 279);
            this.text3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(196, 31);
            this.text3.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(54, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tolerancia: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(54, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cantidad de Iteraciones:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(54, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Valor Inicial: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(54, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Funcion:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(34, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(530, 490);
            this.label11.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGreen;
            this.label15.Location = new System.Drawing.Point(636, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(538, 487);
            this.label15.TabIndex = 63;
            // 
            // Newton_Raphson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1206, 677);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.solucion);
            this.Controls.Add(this.erelativo);
            this.Controls.Add(this.iteraciones);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Newton_Raphson";
            this.Text = "Newton_Raphson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label solucion;
        private System.Windows.Forms.Label erelativo;
        private System.Windows.Forms.Label iteraciones;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
    }
}