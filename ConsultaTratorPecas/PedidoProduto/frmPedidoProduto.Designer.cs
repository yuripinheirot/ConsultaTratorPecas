namespace ConsultaTratorPecas.PedidoProduto
{
    partial class frmPedidoProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCondPag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDataCad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDataReg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTotalBruto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxDescontos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxTotalLiquid = new System.Windows.Forms.TextBox();
            this.dsPedidoProduto = new ConsultaTratorPecas.PedidoProduto.dsPedidoProduto();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoGeralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLiquidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(801, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.descontoGeralDataGridViewTextBoxColumn,
            this.totalLiquidoDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 68);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(861, 259);
            this.dgvProdutos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // tbxCliente
            // 
            this.tbxCliente.Location = new System.Drawing.Point(104, 25);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.ReadOnly = true;
            this.tbxCliente.Size = new System.Drawing.Size(772, 20);
            this.tbxCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pedido";
            // 
            // tbxPedido
            // 
            this.tbxPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPedido.Location = new System.Drawing.Point(15, 25);
            this.tbxPedido.Name = "tbxPedido";
            this.tbxPedido.ReadOnly = true;
            this.tbxPedido.Size = new System.Drawing.Size(83, 20);
            this.tbxPedido.TabIndex = 0;
            this.tbxPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPedido.TextChanged += new System.EventHandler(this.TbxPedido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Condição de pagamento";
            // 
            // tbxCondPag
            // 
            this.tbxCondPag.Location = new System.Drawing.Point(15, 350);
            this.tbxCondPag.Name = "tbxCondPag";
            this.tbxCondPag.ReadOnly = true;
            this.tbxCondPag.Size = new System.Drawing.Size(239, 20);
            this.tbxCondPag.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data de cadastro";
            // 
            // tbxDataCad
            // 
            this.tbxDataCad.Location = new System.Drawing.Point(260, 350);
            this.tbxDataCad.Name = "tbxDataCad";
            this.tbxDataCad.ReadOnly = true;
            this.tbxDataCad.Size = new System.Drawing.Size(103, 20);
            this.tbxDataCad.TabIndex = 4;
            this.tbxDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data de registro";
            // 
            // tbxDataReg
            // 
            this.tbxDataReg.Location = new System.Drawing.Point(369, 350);
            this.tbxDataReg.Name = "tbxDataReg";
            this.tbxDataReg.ReadOnly = true;
            this.tbxDataReg.Size = new System.Drawing.Size(103, 20);
            this.tbxDataReg.TabIndex = 5;
            this.tbxDataReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total bruto";
            // 
            // tbxTotalBruto
            // 
            this.tbxTotalBruto.Location = new System.Drawing.Point(478, 350);
            this.tbxTotalBruto.Name = "tbxTotalBruto";
            this.tbxTotalBruto.ReadOnly = true;
            this.tbxTotalBruto.Size = new System.Drawing.Size(131, 20);
            this.tbxTotalBruto.TabIndex = 6;
            this.tbxTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Descontos";
            // 
            // tbxDescontos
            // 
            this.tbxDescontos.Location = new System.Drawing.Point(615, 350);
            this.tbxDescontos.Name = "tbxDescontos";
            this.tbxDescontos.ReadOnly = true;
            this.tbxDescontos.Size = new System.Drawing.Size(124, 20);
            this.tbxDescontos.TabIndex = 8;
            this.tbxDescontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(742, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total líquido";
            // 
            // tbxTotalLiquid
            // 
            this.tbxTotalLiquid.Location = new System.Drawing.Point(745, 350);
            this.tbxTotalLiquid.Name = "tbxTotalLiquid";
            this.tbxTotalLiquid.ReadOnly = true;
            this.tbxTotalLiquid.Size = new System.Drawing.Size(131, 20);
            this.tbxTotalLiquid.TabIndex = 7;
            this.tbxTotalLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dsPedidoProduto
            // 
            this.dsPedidoProduto.DataSetName = "dsPedidoProduto";
            this.dsPedidoProduto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsPedidoProduto;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Qtd";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.precoUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço unitário";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descontoGeralDataGridViewTextBoxColumn
            // 
            this.descontoGeralDataGridViewTextBoxColumn.DataPropertyName = "DescontoGeral$";
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.descontoGeralDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.descontoGeralDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoGeralDataGridViewTextBoxColumn.Name = "descontoGeralDataGridViewTextBoxColumn";
            this.descontoGeralDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalLiquidoDataGridViewTextBoxColumn
            // 
            this.totalLiquidoDataGridViewTextBoxColumn.DataPropertyName = "TotalLiquido";
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.totalLiquidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.totalLiquidoDataGridViewTextBoxColumn.HeaderText = "Total líquido";
            this.totalLiquidoDataGridViewTextBoxColumn.Name = "totalLiquidoDataGridViewTextBoxColumn";
            this.totalLiquidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPedidoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(889, 427);
            this.Controls.Add(this.tbxTotalLiquid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxDescontos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxTotalBruto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxDataReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxDataCad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCondPag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPedidoProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto por pedido";
            this.Load += new System.EventHandler(this.FrmPedidoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCondPag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDataCad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDataReg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTotalBruto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxDescontos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxTotalLiquid;
        public System.Windows.Forms.TextBox tbxPedido;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dsPedidoProduto dsPedidoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoGeralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLiquidoDataGridViewTextBoxColumn;
    }
}