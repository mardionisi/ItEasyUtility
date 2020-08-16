namespace LibItEasyUtility.UserControls
{
    partial class UserBasic
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
            this.fDataBase = new System.Windows.Forms.TextBox();
            this.fTable = new System.Windows.Forms.TextBox();
            this.LstDatabase = new System.Windows.Forms.ListBox();
            this.LstTables = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboConexao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fDataBase
            // 
            this.fDataBase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDataBase.Location = new System.Drawing.Point(41, 107);
            this.fDataBase.Name = "fDataBase";
            this.fDataBase.Size = new System.Drawing.Size(209, 22);
            this.fDataBase.TabIndex = 49;
            this.fDataBase.TextChanged += new System.EventHandler(this.fDataBase_TextChanged);
            // 
            // fTable
            // 
            this.fTable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTable.Location = new System.Drawing.Point(265, 107);
            this.fTable.Name = "fTable";
            this.fTable.Size = new System.Drawing.Size(209, 22);
            this.fTable.TabIndex = 48;
            this.fTable.TextChanged += new System.EventHandler(this.fTable_TextChanged);
            // 
            // LstDatabase
            // 
            this.LstDatabase.DisplayMember = "name";
            this.LstDatabase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstDatabase.FormattingEnabled = true;
            this.LstDatabase.ItemHeight = 14;
            this.LstDatabase.Location = new System.Drawing.Point(41, 140);
            this.LstDatabase.Name = "LstDatabase";
            this.LstDatabase.Size = new System.Drawing.Size(209, 228);
            this.LstDatabase.TabIndex = 47;
            this.LstDatabase.ValueMember = "database_id";
            this.LstDatabase.SelectedIndexChanged += new System.EventHandler(this.LstDatabase_SelectedIndexChanged);
            // 
            // LstTables
            // 
            this.LstTables.DisplayMember = "name";
            this.LstTables.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstTables.FormattingEnabled = true;
            this.LstTables.ItemHeight = 14;
            this.LstTables.Location = new System.Drawing.Point(251, 126);
            this.LstTables.Name = "LstTables";
            this.LstTables.Size = new System.Drawing.Size(209, 228);
            this.LstTables.TabIndex = 46;
            this.LstTables.ValueMember = "object_id";
            this.LstTables.SelectedIndexChanged += new System.EventHandler(this.LstTables_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboConexao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LstTables);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 382);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Conexões - Base de Dados - Tabelas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 52;
            this.label4.Text = "Conexão";
            // 
            // cboConexao
            // 
            this.cboConexao.DisplayMember = "NomeConexao";
            this.cboConexao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConexao.FormattingEnabled = true;
            this.cboConexao.Location = new System.Drawing.Point(24, 47);
            this.cboConexao.Name = "cboConexao";
            this.cboConexao.Size = new System.Drawing.Size(206, 22);
            this.cboConexao.TabIndex = 51;
            this.cboConexao.ValueMember = "StringConexao";
            this.cboConexao.SelectedIndexChanged += new System.EventHandler(this.cboConexao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco de Dados";
            // 
            // UserBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fDataBase);
            this.Controls.Add(this.fTable);
            this.Controls.Add(this.LstDatabase);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserBasic";
            this.Size = new System.Drawing.Size(518, 408);
            this.Load += new System.EventHandler(this.UserBasic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fDataBase;
        private System.Windows.Forms.TextBox fTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox LstDatabase;
        public System.Windows.Forms.ListBox LstTables;
        public System.Windows.Forms.ComboBox cboConexao;
    }
}
