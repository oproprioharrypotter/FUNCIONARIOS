namespace FUNCIONARIOS
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONÁRIOToolStripMenuItem,
            this.dEPARTAMENTOToolStripMenuItem,
            this.uSUÁRIOToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // fUNCIONÁRIOToolStripMenuItem
            // 
            this.fUNCIONÁRIOToolStripMenuItem.Name = "fUNCIONÁRIOToolStripMenuItem";
            this.fUNCIONÁRIOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fUNCIONÁRIOToolStripMenuItem.Text = "FUNCIONÁRIO";
            this.fUNCIONÁRIOToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONÁRIOToolStripMenuItem_Click);
            // 
            // dEPARTAMENTOToolStripMenuItem
            // 
            this.dEPARTAMENTOToolStripMenuItem.Name = "dEPARTAMENTOToolStripMenuItem";
            this.dEPARTAMENTOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dEPARTAMENTOToolStripMenuItem.Text = "DEPARTAMENTO";
            this.dEPARTAMENTOToolStripMenuItem.Click += new System.EventHandler(this.dEPARTAMENTOToolStripMenuItem_Click);
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            this.uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            this.uSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            this.uSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.uSUÁRIOToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPARTAMENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOToolStripMenuItem;
    }
}