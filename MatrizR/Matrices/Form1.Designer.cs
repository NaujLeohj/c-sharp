namespace Matrices
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
            this.txt_cargar = new System.Windows.Forms.TextBox();
            this.txt_cargar2 = new System.Windows.Forms.TextBox();
            this.txt_cargar3 = new System.Windows.Forms.TextBox();
            this.txt_cargar4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriz1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_descargar = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cargar
            // 
            this.txt_cargar.Location = new System.Drawing.Point(186, 82);
            this.txt_cargar.Name = "txt_cargar";
            this.txt_cargar.Size = new System.Drawing.Size(63, 20);
            this.txt_cargar.TabIndex = 0;
            // 
            // txt_cargar2
            // 
            this.txt_cargar2.Location = new System.Drawing.Point(306, 82);
            this.txt_cargar2.Name = "txt_cargar2";
            this.txt_cargar2.Size = new System.Drawing.Size(63, 20);
            this.txt_cargar2.TabIndex = 1;
            // 
            // txt_cargar3
            // 
            this.txt_cargar3.Location = new System.Drawing.Point(424, 82);
            this.txt_cargar3.Name = "txt_cargar3";
            this.txt_cargar3.Size = new System.Drawing.Size(63, 20);
            this.txt_cargar3.TabIndex = 2;
            // 
            // txt_cargar4
            // 
            this.txt_cargar4.Location = new System.Drawing.Point(548, 82);
            this.txt_cargar4.Name = "txt_cargar4";
            this.txt_cargar4.Size = new System.Drawing.Size(63, 20);
            this.txt_cargar4.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriz1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matriz1ToolStripMenuItem
            // 
            this.matriz1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.descargarToolStripMenuItem});
            this.matriz1ToolStripMenuItem.Name = "matriz1ToolStripMenuItem";
            this.matriz1ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.matriz1ToolStripMenuItem.Text = "Matriz 1";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            this.descargarToolStripMenuItem.Click += new System.EventHandler(this.descargarToolStripMenuItem_Click);
            // 
            // txt_descargar
            // 
            this.txt_descargar.Location = new System.Drawing.Point(186, 154);
            this.txt_descargar.Multiline = true;
            this.txt_descargar.Name = "txt_descargar";
            this.txt_descargar.Size = new System.Drawing.Size(444, 138);
            this.txt_descargar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 409);
            this.Controls.Add(this.txt_descargar);
            this.Controls.Add(this.txt_cargar4);
            this.Controls.Add(this.txt_cargar3);
            this.Controls.Add(this.txt_cargar2);
            this.Controls.Add(this.txt_cargar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cargar;
        private System.Windows.Forms.TextBox txt_cargar2;
        private System.Windows.Forms.TextBox txt_cargar3;
        private System.Windows.Forms.TextBox txt_cargar4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriz1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_descargar;
    }
}

