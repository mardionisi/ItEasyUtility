namespace ItEasyUtility
{
    partial class pesquisacolumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisacolumns));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txBuscaCampo = new System.Windows.Forms.TextBox();
            this.gwSearch = new System.Windows.Forms.DataGridView();
            this.userConn = new LibItEasyUtility.UserControls.UserConexao();
            this.userDatabase = new LibItEasyUtility.UserControls.UserBancoDados();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, -13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Conexão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ItEasyUtility.Properties.Resources.owl_transp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 90);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(789, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 50);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(11, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "BUSCAR";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txValor);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(583, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 50);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Valor ";
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(11, 19);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(181, 22);
            this.txValor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBuscaCampo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Buscar o Campo ";
            // 
            // txBuscaCampo
            // 
            this.txBuscaCampo.Location = new System.Drawing.Point(6, 19);
            this.txBuscaCampo.Name = "txBuscaCampo";
            this.txBuscaCampo.Size = new System.Drawing.Size(187, 22);
            this.txBuscaCampo.TabIndex = 0;
            // 
            // gwSearch
            // 
            this.gwSearch.AllowUserToAddRows = false;
            this.gwSearch.AllowUserToDeleteRows = false;
            this.gwSearch.AllowUserToOrderColumns = true;
            this.gwSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwSearch.Location = new System.Drawing.Point(374, 76);
            this.gwSearch.Name = "gwSearch";
            this.gwSearch.ReadOnly = true;
            this.gwSearch.RowHeadersVisible = false;
            this.gwSearch.Size = new System.Drawing.Size(537, 178);
            this.gwSearch.TabIndex = 61;
            // 
            // userConn
            // 
            this.userConn.Location = new System.Drawing.Point(129, -1);
            this.userConn.Name = "userConn";
            this.userConn.Size = new System.Drawing.Size(235, 62);
            this.userConn.TabIndex = 54;
            // 
            // userDatabase
            // 
            this.userDatabase.Conexao = null;
            this.userDatabase.Location = new System.Drawing.Point(131, 55);
            this.userDatabase.Name = "userDatabase";
            this.userDatabase.Size = new System.Drawing.Size(235, 214);
            this.userDatabase.TabIndex = 53;
            // 
            // pesquisacolumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 282);
            this.Controls.Add(this.gwSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userConn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisacolumns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pesquisacolumns";
            this.Load += new System.EventHandler(this.pesquisacolumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txBuscaCampo;
        private System.Windows.Forms.DataGridView gwSearch;
        public LibItEasyUtility.UserControls.UserBancoDados userDatabase;
        public LibItEasyUtility.UserControls.UserConexao userConn;
    }
}