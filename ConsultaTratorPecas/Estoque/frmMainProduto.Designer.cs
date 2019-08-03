namespace ConsultaTratorPecas.Estoque
{
    partial class frmMainProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvComprasEst = new System.Windows.Forms.DataGridView();
            this.lblEncontrados = new System.Windows.Forms.Label();
            this.chkInativos = new System.Windows.Forms.CheckBox();
            this.cbxPesquissarPor = new System.Windows.Forms.ComboBox();
            this.tbxPalavraChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(713, 368);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // dgvComprasEst
            // 
            this.dgvComprasEst.AllowUserToAddRows = false;
            this.dgvComprasEst.AllowUserToDeleteRows = false;
            this.dgvComprasEst.AllowUserToOrderColumns = true;
            this.dgvComprasEst.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprasEst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprasEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasEst.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComprasEst.Location = new System.Drawing.Point(16, 25);
            this.dgvComprasEst.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComprasEst.MultiSelect = false;
            this.dgvComprasEst.Name = "dgvComprasEst";
            this.dgvComprasEst.ReadOnly = true;
            this.dgvComprasEst.RowHeadersWidth = 24;
            this.dgvComprasEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasEst.Size = new System.Drawing.Size(772, 270);
            this.dgvComprasEst.TabIndex = 4;
            // 
            // lblEncontrados
            // 
            this.lblEncontrados.AutoSize = true;
            this.lblEncontrados.Location = new System.Drawing.Point(13, 8);
            this.lblEncontrados.Name = "lblEncontrados";
            this.lblEncontrados.Size = new System.Drawing.Size(114, 13);
            this.lblEncontrados.TabIndex = 6;
            this.lblEncontrados.Text = "Produtos encontrados:";
            // 
            // chkInativos
            // 
            this.chkInativos.AutoSize = true;
            this.chkInativos.Location = new System.Drawing.Point(688, 5);
            this.chkInativos.Name = "chkInativos";
            this.chkInativos.Size = new System.Drawing.Size(100, 17);
            this.chkInativos.TabIndex = 3;
            this.chkInativos.Text = "Mostrar inativos";
            this.chkInativos.UseVisualStyleBackColor = true;
            // 
            // cbxPesquissarPor
            // 
            this.cbxPesquissarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPesquissarPor.FormattingEnabled = true;
            this.cbxPesquissarPor.Items.AddRange(new object[] {
            "Código",
            "Descrição",
            "Marca",
            "Número",
            "Referência do fornecedor"});
            this.cbxPesquissarPor.Location = new System.Drawing.Point(16, 331);
            this.cbxPesquissarPor.Name = "cbxPesquissarPor";
            this.cbxPesquissarPor.Size = new System.Drawing.Size(199, 21);
            this.cbxPesquissarPor.TabIndex = 5;
            // 
            // tbxPalavraChave
            // 
            this.tbxPalavraChave.Location = new System.Drawing.Point(16, 371);
            this.tbxPalavraChave.Name = "tbxPalavraChave";
            this.tbxPalavraChave.Size = new System.Drawing.Size(199, 20);
            this.tbxPalavraChave.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pesquisar por";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Palavra chave";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(632, 368);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // frmMainProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPalavraChave);
            this.Controls.Add(this.cbxPesquissarPor);
            this.Controls.Add(this.chkInativos);
            this.Controls.Add(this.lblEncontrados);
            this.Controls.Add(this.dgvComprasEst);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMainProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de produtos";
            this.Load += new System.EventHandler(this.FrmMainProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvComprasEst;
        private System.Windows.Forms.Label lblEncontrados;
        private System.Windows.Forms.CheckBox chkInativos;
        private System.Windows.Forms.ComboBox cbxPesquissarPor;
        private System.Windows.Forms.TextBox tbxPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserir;
    }
}