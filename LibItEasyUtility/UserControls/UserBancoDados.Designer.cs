namespace LibItEasyUtility.UserControls
{
    partial class UserBancoDados
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
            this.label4 = new System.Windows.Forms.Label();
            this.fDataBase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListDatabase = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 56;
            this.label4.Text = "Filtro";
            // 
            // fDataBase
            // 
            this.fDataBase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDataBase.Location = new System.Drawing.Point(48, 26);
            this.fDataBase.Name = "fDataBase";
            this.fDataBase.Size = new System.Drawing.Size(165, 22);
            this.fDataBase.TabIndex = 57;
            this.fDataBase.TextChanged += new System.EventHandler(this.tDatabase_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListDatabase);
            this.groupBox1.Controls.Add(this.fDataBase);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 196);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Banco de Dados ";
            // 
            // ListDatabase
            // 
            this.ListDatabase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDatabase.FormattingEnabled = true;
            this.ListDatabase.ItemHeight = 14;
            this.ListDatabase.Location = new System.Drawing.Point(7, 60);
            this.ListDatabase.Name = "ListDatabase";
            this.ListDatabase.Size = new System.Drawing.Size(206, 130);
            this.ListDatabase.TabIndex = 58;
            // 
            // UserBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserBancoDados";
            this.Size = new System.Drawing.Size(235, 218);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fDataBase;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox ListDatabase;
    }
}
