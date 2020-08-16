namespace ItEasyUtility.UserControls
{
    partial class UserMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItEasyMenu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItEasyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItEasyMenu
            // 
            this.ItEasyMenu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ItEasyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.buscaToolStripMenuItem});
            this.ItEasyMenu.Location = new System.Drawing.Point(0, 0);
            this.ItEasyMenu.Name = "ItEasyMenu";
            this.ItEasyMenu.Size = new System.Drawing.Size(325, 25);
            this.ItEasyMenu.TabIndex = 1;
            this.ItEasyMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.buscaToolStripMenuItem.Text = "Busca";
            this.buscaToolStripMenuItem.Click += new System.EventHandler(this.buscaToolStripMenuItem_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItEasyMenu);
            this.Name = "UserMenu";
            this.Size = new System.Drawing.Size(325, 31);
            this.ItEasyMenu.ResumeLayout(false);
            this.ItEasyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ItEasyMenu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
    }
}
