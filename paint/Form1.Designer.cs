namespace paint
{
    partial class Form1
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
            this.btn_drawline = new System.Windows.Forms.Button();
            this.btn_drawRec = new System.Windows.Forms.Button();
            this.btn_DrawEclipse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_drawline
            // 
            this.btn_drawline.Location = new System.Drawing.Point(-1, 3);
            this.btn_drawline.Name = "btn_drawline";
            this.btn_drawline.Size = new System.Drawing.Size(88, 54);
            this.btn_drawline.TabIndex = 0;
            this.btn_drawline.Text = "Draw Line";
            this.btn_drawline.UseVisualStyleBackColor = true;
            this.btn_drawline.Click += new System.EventHandler(this.btn_drawline_Click);
            // 
            // btn_drawRec
            // 
            this.btn_drawRec.Location = new System.Drawing.Point(0, 101);
            this.btn_drawRec.Name = "btn_drawRec";
            this.btn_drawRec.Size = new System.Drawing.Size(87, 57);
            this.btn_drawRec.TabIndex = 1;
            this.btn_drawRec.Text = "Draw Rectangle";
            this.btn_drawRec.UseVisualStyleBackColor = true;
            this.btn_drawRec.Click += new System.EventHandler(this.btn_drawRec_Click);
            // 
            // btn_DrawEclipse
            // 
            this.btn_DrawEclipse.Location = new System.Drawing.Point(0, 213);
            this.btn_DrawEclipse.Name = "btn_DrawEclipse";
            this.btn_DrawEclipse.Size = new System.Drawing.Size(87, 54);
            this.btn_DrawEclipse.TabIndex = 2;
            this.btn_DrawEclipse.Text = "Draw Eclipse";
            this.btn_DrawEclipse.UseVisualStyleBackColor = true;
            this.btn_DrawEclipse.Click += new System.EventHandler(this.btn_DrawEclipse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btn_drawline);
            this.panel1.Controls.Add(this.btn_DrawEclipse);
            this.panel1.Controls.Add(this.btn_drawRec);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 293);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.eToolStripMenuItem.Text = "&Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_drawline;
        private System.Windows.Forms.Button btn_drawRec;
        private System.Windows.Forms.Button btn_DrawEclipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

