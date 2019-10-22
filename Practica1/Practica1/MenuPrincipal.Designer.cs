namespace Practica1
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unidad1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosCerradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bissecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglasFalsasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosAbiertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeCurvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidad1ToolStripMenuItem,
            this.unidad2ToolStripMenuItem,
            this.unidad3ToolStripMenuItem,
            this.unidad4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unidad1ToolStripMenuItem
            // 
            this.unidad1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodosCerradosToolStripMenuItem,
            this.metodosAbiertosToolStripMenuItem});
            this.unidad1ToolStripMenuItem.Name = "unidad1ToolStripMenuItem";
            this.unidad1ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.unidad1ToolStripMenuItem.Text = "Unidad 1";
            // 
            // metodosCerradosToolStripMenuItem
            // 
            this.metodosCerradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bissecionToolStripMenuItem,
            this.reglasFalsasToolStripMenuItem});
            this.metodosCerradosToolStripMenuItem.Name = "metodosCerradosToolStripMenuItem";
            this.metodosCerradosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.metodosCerradosToolStripMenuItem.Text = "Metodos Cerrados";
            // 
            // bissecionToolStripMenuItem
            // 
            this.bissecionToolStripMenuItem.Name = "bissecionToolStripMenuItem";
            this.bissecionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.bissecionToolStripMenuItem.Text = "Biseccion";
            this.bissecionToolStripMenuItem.Click += new System.EventHandler(this.bissecionToolStripMenuItem_Click);
            // 
            // reglasFalsasToolStripMenuItem
            // 
            this.reglasFalsasToolStripMenuItem.Name = "reglasFalsasToolStripMenuItem";
            this.reglasFalsasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reglasFalsasToolStripMenuItem.Text = "Regla Falsa";
            this.reglasFalsasToolStripMenuItem.Click += new System.EventHandler(this.reglasFalsasToolStripMenuItem_Click);
            // 
            // metodosAbiertosToolStripMenuItem
            // 
            this.metodosAbiertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonRaphsonToolStripMenuItem,
            this.secanteToolStripMenuItem});
            this.metodosAbiertosToolStripMenuItem.Name = "metodosAbiertosToolStripMenuItem";
            this.metodosAbiertosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.metodosAbiertosToolStripMenuItem.Text = "Metodos Abiertos";
            // 
            // newtonRaphsonToolStripMenuItem
            // 
            this.newtonRaphsonToolStripMenuItem.Name = "newtonRaphsonToolStripMenuItem";
            this.newtonRaphsonToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newtonRaphsonToolStripMenuItem.Text = "Newton - Raphson";
            this.newtonRaphsonToolStripMenuItem.Click += new System.EventHandler(this.newtonRaphsonToolStripMenuItem_Click);
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.secanteToolStripMenuItem.Text = "Secante";
            this.secanteToolStripMenuItem.Click += new System.EventHandler(this.secanteToolStripMenuItem_Click);
            // 
            // unidad2ToolStripMenuItem
            // 
            this.unidad2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matricesToolStripMenuItem});
            this.unidad2ToolStripMenuItem.Name = "unidad2ToolStripMenuItem";
            this.unidad2ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.unidad2ToolStripMenuItem.Text = "Unidad 2";
            // 
            // matricesToolStripMenuItem
            // 
            this.matricesToolStripMenuItem.Name = "matricesToolStripMenuItem";
            this.matricesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matricesToolStripMenuItem.Text = "Matrices";
            this.matricesToolStripMenuItem.Click += new System.EventHandler(this.MatricesToolStripMenuItem_Click);
            // 
            // unidad3ToolStripMenuItem
            // 
            this.unidad3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajusteDeCurvasToolStripMenuItem});
            this.unidad3ToolStripMenuItem.Name = "unidad3ToolStripMenuItem";
            this.unidad3ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.unidad3ToolStripMenuItem.Text = "Unidad 3";
            // 
            // unidad4ToolStripMenuItem
            // 
            this.unidad4ToolStripMenuItem.Name = "unidad4ToolStripMenuItem";
            this.unidad4ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.unidad4ToolStripMenuItem.Text = "Unidad 4";
            // 
            // ajusteDeCurvasToolStripMenuItem
            // 
            this.ajusteDeCurvasToolStripMenuItem.Name = "ajusteDeCurvasToolStripMenuItem";
            this.ajusteDeCurvasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajusteDeCurvasToolStripMenuItem.Text = "Ajuste de curvas";
            this.ajusteDeCurvasToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeCurvasToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unidad1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosCerradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bissecionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglasFalsasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosAbiertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeCurvasToolStripMenuItem;
    }
}

