namespace LibItEasyUtility.UserControls
{
    partial class UserColumns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fColumn = new System.Windows.Forms.TextBox();
            this.gwColumns = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboConvertType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tVariavel = new System.Windows.Forms.TextBox();
            this.tTamanho = new System.Windows.Forms.TextBox();
            this.tTipo = new System.Windows.Forms.TextBox();
            this.tOrdem = new System.Windows.Forms.TextBox();
            this.tNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gwColumns)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fColumn
            // 
            this.fColumn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fColumn.Location = new System.Drawing.Point(12, 48);
            this.fColumn.Name = "fColumn";
            this.fColumn.Size = new System.Drawing.Size(210, 21);
            this.fColumn.TabIndex = 44;
            this.fColumn.TextChanged += new System.EventHandler(this.fColumn_TextChanged);
            // 
            // gwColumns
            // 
            this.gwColumns.AllowUserToAddRows = false;
            this.gwColumns.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gwColumns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gwColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gwColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.gwColumns.Location = new System.Drawing.Point(12, 78);
            this.gwColumns.Name = "gwColumns";
            this.gwColumns.ReadOnly = true;
            this.gwColumns.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gwColumns.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gwColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gwColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwColumns.Size = new System.Drawing.Size(694, 212);
            this.gwColumns.TabIndex = 43;
            this.gwColumns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwColumns_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 380.7107F;
            this.Column1.HeaderText = "NOME";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "column_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 7.566255F;
            this.Column2.HeaderText = "ORDEM";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeName";
            this.Column3.FillWeight = 7.566255F;
            this.Column3.HeaderText = "TIPO";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "max_length";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FillWeight = 7.566255F;
            this.Column4.HeaderText = "TAMANHO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TypeNameConvert";
            this.Column6.HeaderText = "CONVERTED TYPE";
            this.Column6.MinimumWidth = 100;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ColumnOwner";
            this.Column5.HeaderText = "VARIÁVEL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboConvertType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tVariavel);
            this.groupBox1.Controls.Add(this.tTamanho);
            this.groupBox1.Controls.Add(this.tTipo);
            this.groupBox1.Controls.Add(this.tOrdem);
            this.groupBox1.Controls.Add(this.tNome);
            this.groupBox1.Controls.Add(this.fColumn);
            this.groupBox1.Controls.Add(this.gwColumns);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 348);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Colunas";
            // 
            // cboConvertType
            // 
            this.cboConvertType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConvertType.FormattingEnabled = true;
            this.cboConvertType.Location = new System.Drawing.Point(415, 314);
            this.cboConvertType.Name = "cboConvertType";
            this.cboConvertType.Size = new System.Drawing.Size(137, 21);
            this.cboConvertType.TabIndex = 56;
            this.cboConvertType.SelectedIndexChanged += new System.EventHandler(this.cboConvertType_SelectedIndexChanged);
            this.cboConvertType.Leave += new System.EventHandler(this.cboConvertType_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Convert Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Variavel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tamanho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ordem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Nome";
            // 
            // tVariavel
            // 
            this.tVariavel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVariavel.Location = new System.Drawing.Point(558, 314);
            this.tVariavel.Name = "tVariavel";
            this.tVariavel.Size = new System.Drawing.Size(151, 21);
            this.tVariavel.TabIndex = 49;
            this.tVariavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tVariavel_KeyDown);
            this.tVariavel.Leave += new System.EventHandler(this.tVariavel_Leave);
            // 
            // tTamanho
            // 
            this.tTamanho.Enabled = false;
            this.tTamanho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTamanho.Location = new System.Drawing.Point(347, 314);
            this.tTamanho.Name = "tTamanho";
            this.tTamanho.Size = new System.Drawing.Size(61, 21);
            this.tTamanho.TabIndex = 48;
            // 
            // tTipo
            // 
            this.tTipo.Enabled = false;
            this.tTipo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTipo.Location = new System.Drawing.Point(238, 314);
            this.tTipo.Name = "tTipo";
            this.tTipo.Size = new System.Drawing.Size(107, 21);
            this.tTipo.TabIndex = 47;
            // 
            // tOrdem
            // 
            this.tOrdem.Enabled = false;
            this.tOrdem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrdem.Location = new System.Drawing.Point(180, 314);
            this.tOrdem.Name = "tOrdem";
            this.tOrdem.Size = new System.Drawing.Size(50, 21);
            this.tOrdem.TabIndex = 46;
            // 
            // tNome
            // 
            this.tNome.Enabled = false;
            this.tNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNome.Location = new System.Drawing.Point(9, 314);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(163, 21);
            this.tNome.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Filtrar Campos";
            // 
            // UserColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserColumns";
            this.Size = new System.Drawing.Size(747, 367);
            this.Load += new System.EventHandler(this.UserColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwColumns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fColumn;
        private System.Windows.Forms.DataGridView gwColumns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cboConvertType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tVariavel;
        private System.Windows.Forms.TextBox tTamanho;
        private System.Windows.Forms.TextBox tTipo;
        private System.Windows.Forms.TextBox tOrdem;
        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.Label label1;
    }
}
