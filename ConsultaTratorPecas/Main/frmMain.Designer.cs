namespace ConsultaTratorPecas.Main
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcPedidos = new System.Windows.Forms.TabPage();
            this.tbxTotalLiquid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxDescontos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxTotalBruto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxDataReg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxDataCad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxCondPag = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvPedProdutos = new System.Windows.Forms.DataGridView();
            this.produtoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoGeralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLiquidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPedidoProduto = new ConsultaTratorPecas.PedidoProduto.dsPedidoProduto();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.tbxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbxDataFin = new System.Windows.Forms.DateTimePicker();
            this.tbxDataIni = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPedidosEnc = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDgvPedidos = new ConsultaTratorPecas.Main.dsDgvPedidos();
            this.tbxEstoque = new System.Windows.Forms.TabPage();
            this.cbxPesquisarPor = new System.Windows.Forms.ComboBox();
            this.tbxDescProduto = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.tbxDataFinEst = new System.Windows.Forms.DateTimePicker();
            this.tbxDataIniEst = new System.Windows.Forms.DateTimePicker();
            this.dgvPdtVenda = new System.Windows.Forms.DataGridView();
            this.codVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVendidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPdtVenda = new ConsultaTratorPecas.Main.dsPdtVenda();
            this.dgvPdtCompra = new System.Windows.Forms.DataGridView();
            this.numeroNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLannDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcompraItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPdtCompa = new ConsultaTratorPecas.Main.dsPdtCompa();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarEst = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbcPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).BeginInit();
            this.tbxEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtCompa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcPedidos);
            this.tabControl1.Controls.Add(this.tbxEstoque);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 687);
            this.tabControl1.TabIndex = 0;
            // 
            // tbcPedidos
            // 
            this.tbcPedidos.Controls.Add(this.tbxTotalLiquid);
            this.tbcPedidos.Controls.Add(this.label11);
            this.tbcPedidos.Controls.Add(this.tbxDescontos);
            this.tbcPedidos.Controls.Add(this.label10);
            this.tbcPedidos.Controls.Add(this.tbxTotalBruto);
            this.tbcPedidos.Controls.Add(this.label12);
            this.tbcPedidos.Controls.Add(this.tbxDataReg);
            this.tbcPedidos.Controls.Add(this.label13);
            this.tbcPedidos.Controls.Add(this.tbxDataCad);
            this.tbcPedidos.Controls.Add(this.label14);
            this.tbcPedidos.Controls.Add(this.tbxCondPag);
            this.tbcPedidos.Controls.Add(this.label15);
            this.tbcPedidos.Controls.Add(this.label16);
            this.tbcPedidos.Controls.Add(this.dgvPedProdutos);
            this.tbcPedidos.Controls.Add(this.lblValorTotal);
            this.tbcPedidos.Controls.Add(this.btnVisualizar);
            this.tbcPedidos.Controls.Add(this.tbxIdCliente);
            this.tbcPedidos.Controls.Add(this.btnPesquisar);
            this.tbcPedidos.Controls.Add(this.tbxDataFin);
            this.tbcPedidos.Controls.Add(this.tbxDataIni);
            this.tbcPedidos.Controls.Add(this.label6);
            this.tbcPedidos.Controls.Add(this.label3);
            this.tbcPedidos.Controls.Add(this.label4);
            this.tbcPedidos.Controls.Add(this.tbxNomeCliente);
            this.tbcPedidos.Controls.Add(this.label5);
            this.tbcPedidos.Controls.Add(this.lblPedidosEnc);
            this.tbcPedidos.Controls.Add(this.btnSair);
            this.tbcPedidos.Controls.Add(this.dgvPedidos);
            this.tbcPedidos.Location = new System.Drawing.Point(4, 22);
            this.tbcPedidos.Name = "tbcPedidos";
            this.tbcPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPedidos.Size = new System.Drawing.Size(1003, 661);
            this.tbcPedidos.TabIndex = 0;
            this.tbcPedidos.Text = "Pedidos";
            this.tbcPedidos.UseVisualStyleBackColor = true;
            // 
            // tbxTotalLiquid
            // 
            this.tbxTotalLiquid.Location = new System.Drawing.Point(860, 563);
            this.tbxTotalLiquid.Name = "tbxTotalLiquid";
            this.tbxTotalLiquid.ReadOnly = true;
            this.tbxTotalLiquid.Size = new System.Drawing.Size(131, 20);
            this.tbxTotalLiquid.TabIndex = 27;
            this.tbxTotalLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(857, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total líquido";
            // 
            // tbxDescontos
            // 
            this.tbxDescontos.Location = new System.Drawing.Point(730, 563);
            this.tbxDescontos.Name = "tbxDescontos";
            this.tbxDescontos.ReadOnly = true;
            this.tbxDescontos.Size = new System.Drawing.Size(124, 20);
            this.tbxDescontos.TabIndex = 35;
            this.tbxDescontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(727, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Descontos";
            // 
            // tbxTotalBruto
            // 
            this.tbxTotalBruto.Location = new System.Drawing.Point(593, 563);
            this.tbxTotalBruto.Name = "tbxTotalBruto";
            this.tbxTotalBruto.ReadOnly = true;
            this.tbxTotalBruto.Size = new System.Drawing.Size(131, 20);
            this.tbxTotalBruto.TabIndex = 26;
            this.tbxTotalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Total bruto";
            // 
            // tbxDataReg
            // 
            this.tbxDataReg.Location = new System.Drawing.Point(484, 563);
            this.tbxDataReg.Name = "tbxDataReg";
            this.tbxDataReg.ReadOnly = true;
            this.tbxDataReg.Size = new System.Drawing.Size(103, 20);
            this.tbxDataReg.TabIndex = 25;
            this.tbxDataReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 547);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Data de registro";
            // 
            // tbxDataCad
            // 
            this.tbxDataCad.Location = new System.Drawing.Point(375, 563);
            this.tbxDataCad.Name = "tbxDataCad";
            this.tbxDataCad.ReadOnly = true;
            this.tbxDataCad.Size = new System.Drawing.Size(103, 20);
            this.tbxDataCad.TabIndex = 24;
            this.tbxDataCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 547);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Data de cadastro";
            // 
            // tbxCondPag
            // 
            this.tbxCondPag.Location = new System.Drawing.Point(10, 563);
            this.tbxCondPag.Name = "tbxCondPag";
            this.tbxCondPag.ReadOnly = true;
            this.tbxCondPag.Size = new System.Drawing.Size(359, 20);
            this.tbxCondPag.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Condição de pagamento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Produtos";
            // 
            // dgvPedProdutos
            // 
            this.dgvPedProdutos.AllowUserToAddRows = false;
            this.dgvPedProdutos.AllowUserToDeleteRows = false;
            this.dgvPedProdutos.AllowUserToOrderColumns = true;
            this.dgvPedProdutos.AutoGenerateColumns = false;
            this.dgvPedProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoDataGridViewTextBoxColumn2,
            this.descricaoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.descontoGeralDataGridViewTextBoxColumn,
            this.totalLiquidoDataGridViewTextBoxColumn});
            this.dgvPedProdutos.DataSource = this.dataTable1BindingSource3;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedProdutos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedProdutos.Location = new System.Drawing.Point(11, 408);
            this.dgvPedProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedProdutos.MultiSelect = false;
            this.dgvPedProdutos.Name = "dgvPedProdutos";
            this.dgvPedProdutos.ReadOnly = true;
            this.dgvPedProdutos.RowHeadersWidth = 24;
            this.dgvPedProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedProdutos.Size = new System.Drawing.Size(980, 135);
            this.dgvPedProdutos.TabIndex = 6;
            // 
            // produtoDataGridViewTextBoxColumn2
            // 
            this.produtoDataGridViewTextBoxColumn2.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn2.HeaderText = "Cod";
            this.produtoDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.produtoDataGridViewTextBoxColumn2.Name = "produtoDataGridViewTextBoxColumn2";
            this.produtoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn2.Width = 65;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 325;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 175;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Qtd";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 70;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.precoUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço Unit";
            this.precoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            this.precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoGeralDataGridViewTextBoxColumn
            // 
            this.descontoGeralDataGridViewTextBoxColumn.DataPropertyName = "DescontoGeral$";
            dataGridViewCellStyle4.Format = "N2";
            this.descontoGeralDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.descontoGeralDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoGeralDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoGeralDataGridViewTextBoxColumn.Name = "descontoGeralDataGridViewTextBoxColumn";
            this.descontoGeralDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoGeralDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalLiquidoDataGridViewTextBoxColumn
            // 
            this.totalLiquidoDataGridViewTextBoxColumn.DataPropertyName = "TotalLiquido";
            dataGridViewCellStyle5.Format = "N2";
            this.totalLiquidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalLiquidoDataGridViewTextBoxColumn.HeaderText = "Total Líquido";
            this.totalLiquidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalLiquidoDataGridViewTextBoxColumn.Name = "totalLiquidoDataGridViewTextBoxColumn";
            this.totalLiquidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalLiquidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dsPedidoProduto;
            // 
            // dsPedidoProduto
            // 
            this.dsPedidoProduto.DataSetName = "dsPedidoProduto";
            this.dsPedidoProduto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(8, 630);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(89, 20);
            this.lblValorTotal.TabIndex = 21;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(835, 665);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 20;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // tbxIdCliente
            // 
            this.tbxIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdCliente.Location = new System.Drawing.Point(11, 22);
            this.tbxIdCliente.Mask = "000000";
            this.tbxIdCliente.Name = "tbxIdCliente";
            this.tbxIdCliente.PromptChar = ' ';
            this.tbxIdCliente.Size = new System.Drawing.Size(67, 20);
            this.tbxIdCliente.TabIndex = 0;
            this.tbxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdCliente.TextChanged += new System.EventHandler(this.TbxIdCliente_TextChanged);
            this.tbxIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdCliente_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(670, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // tbxDataFin
            // 
            this.tbxDataFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataFin.Location = new System.Drawing.Point(568, 22);
            this.tbxDataFin.Name = "tbxDataFin";
            this.tbxDataFin.Size = new System.Drawing.Size(96, 20);
            this.tbxDataFin.TabIndex = 3;
            // 
            // tbxDataIni
            // 
            this.tbxDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIni.Location = new System.Drawing.Point(465, 22);
            this.tbxDataIni.Name = "tbxDataIni";
            this.tbxDataIni.Size = new System.Drawing.Size(96, 20);
            this.tbxDataIni.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome";
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomeCliente.Location = new System.Drawing.Point(84, 22);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.ReadOnly = true;
            this.tbxNomeCliente.Size = new System.Drawing.Size(375, 20);
            this.tbxNomeCliente.TabIndex = 1;
            this.tbxNomeCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data inicial";
            // 
            // lblPedidosEnc
            // 
            this.lblPedidosEnc.AutoSize = true;
            this.lblPedidosEnc.Location = new System.Drawing.Point(7, 51);
            this.lblPedidosEnc.Name = "lblPedidosEnc";
            this.lblPedidosEnc.Size = new System.Drawing.Size(113, 13);
            this.lblPedidosEnc.TabIndex = 15;
            this.lblPedidosEnc.Text = "Pedidos encontrados: ";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(916, 630);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToOrderColumns = true;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 68);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(980, 319);
            this.dgvPedidos.TabIndex = 5;
            this.dgvPedidos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellEnter);
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn.Width = 75;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 450;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Width = 95;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.totalVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total venda";
            this.totalVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsDgvPedidos;
            // 
            // dsDgvPedidos
            // 
            this.dsDgvPedidos.DataSetName = "dsDgvPedidos";
            this.dsDgvPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxEstoque
            // 
            this.tbxEstoque.Controls.Add(this.cbxPesquisarPor);
            this.tbxEstoque.Controls.Add(this.tbxDescProduto);
            this.tbxEstoque.Controls.Add(this.tbxCodigo);
            this.tbxEstoque.Controls.Add(this.tbxDataFinEst);
            this.tbxEstoque.Controls.Add(this.tbxDataIniEst);
            this.tbxEstoque.Controls.Add(this.dgvPdtVenda);
            this.tbxEstoque.Controls.Add(this.dgvPdtCompra);
            this.tbxEstoque.Controls.Add(this.label8);
            this.tbxEstoque.Controls.Add(this.label9);
            this.tbxEstoque.Controls.Add(this.label7);
            this.tbxEstoque.Controls.Add(this.label2);
            this.tbxEstoque.Controls.Add(this.label17);
            this.tbxEstoque.Controls.Add(this.label18);
            this.tbxEstoque.Controls.Add(this.label1);
            this.tbxEstoque.Controls.Add(this.btnPesquisarEst);
            this.tbxEstoque.Location = new System.Drawing.Point(4, 22);
            this.tbxEstoque.Name = "tbxEstoque";
            this.tbxEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbxEstoque.Size = new System.Drawing.Size(1003, 661);
            this.tbxEstoque.TabIndex = 1;
            this.tbxEstoque.Text = "Estoque";
            this.tbxEstoque.UseVisualStyleBackColor = true;
            // 
            // cbxPesquisarPor
            // 
            this.cbxPesquisarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPesquisarPor.FormattingEnabled = true;
            this.cbxPesquisarPor.Items.AddRange(new object[] {
            "Produto",
            "Fornecedor"});
            this.cbxPesquisarPor.Location = new System.Drawing.Point(11, 22);
            this.cbxPesquisarPor.Name = "cbxPesquisarPor";
            this.cbxPesquisarPor.Size = new System.Drawing.Size(137, 21);
            this.cbxPesquisarPor.TabIndex = 7;
            // 
            // tbxDescProduto
            // 
            this.tbxDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescProduto.Location = new System.Drawing.Point(227, 23);
            this.tbxDescProduto.Name = "tbxDescProduto";
            this.tbxDescProduto.ReadOnly = true;
            this.tbxDescProduto.Size = new System.Drawing.Size(464, 20);
            this.tbxDescProduto.TabIndex = 1;
            this.tbxDescProduto.TabStop = false;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(154, 23);
            this.tbxCodigo.Mask = "000000";
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.PromptChar = ' ';
            this.tbxCodigo.Size = new System.Drawing.Size(67, 20);
            this.tbxCodigo.TabIndex = 0;
            this.tbxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxProdutoEst_KeyDown);
            this.tbxCodigo.Leave += new System.EventHandler(this.TbxIdProduto_Leave);
            // 
            // tbxDataFinEst
            // 
            this.tbxDataFinEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataFinEst.Location = new System.Drawing.Point(799, 23);
            this.tbxDataFinEst.Name = "tbxDataFinEst";
            this.tbxDataFinEst.Size = new System.Drawing.Size(95, 20);
            this.tbxDataFinEst.TabIndex = 3;
            // 
            // tbxDataIniEst
            // 
            this.tbxDataIniEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIniEst.Location = new System.Drawing.Point(697, 23);
            this.tbxDataIniEst.Name = "tbxDataIniEst";
            this.tbxDataIniEst.Size = new System.Drawing.Size(95, 20);
            this.tbxDataIniEst.TabIndex = 2;
            // 
            // dgvPdtVenda
            // 
            this.dgvPdtVenda.AllowUserToAddRows = false;
            this.dgvPdtVenda.AllowUserToDeleteRows = false;
            this.dgvPdtVenda.AllowUserToOrderColumns = true;
            this.dgvPdtVenda.AutoGenerateColumns = false;
            this.dgvPdtVenda.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdtVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPdtVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPdtVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVendaDataGridViewTextBoxColumn,
            this.Cliente,
            this.dataCadastroDataGridViewTextBoxColumn1,
            this.refFornecedorDataGridViewTextBoxColumn,
            this.qtdVendidaDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn1,
            this.totalVendidoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn});
            this.dgvPdtVenda.DataSource = this.dataTable1BindingSource2;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPdtVenda.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPdtVenda.Location = new System.Drawing.Point(11, 362);
            this.dgvPdtVenda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPdtVenda.MultiSelect = false;
            this.dgvPdtVenda.Name = "dgvPdtVenda";
            this.dgvPdtVenda.ReadOnly = true;
            this.dgvPdtVenda.RowHeadersWidth = 24;
            this.dgvPdtVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPdtVenda.Size = new System.Drawing.Size(980, 270);
            this.dgvPdtVenda.TabIndex = 6;
            // 
            // codVendaDataGridViewTextBoxColumn
            // 
            this.codVendaDataGridViewTextBoxColumn.DataPropertyName = "CodVenda";
            this.codVendaDataGridViewTextBoxColumn.HeaderText = "Venda";
            this.codVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVendaDataGridViewTextBoxColumn.Name = "codVendaDataGridViewTextBoxColumn";
            this.codVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVendaDataGridViewTextBoxColumn.Width = 75;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 348;
            // 
            // dataCadastroDataGridViewTextBoxColumn1
            // 
            this.dataCadastroDataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn1.HeaderText = "Data cadastro";
            this.dataCadastroDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn1.Name = "dataCadastroDataGridViewTextBoxColumn1";
            this.dataCadastroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataCadastroDataGridViewTextBoxColumn1.Width = 125;
            // 
            // refFornecedorDataGridViewTextBoxColumn
            // 
            this.refFornecedorDataGridViewTextBoxColumn.DataPropertyName = "RefFornecedor";
            this.refFornecedorDataGridViewTextBoxColumn.HeaderText = "Ref fornecedor";
            this.refFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refFornecedorDataGridViewTextBoxColumn.Name = "refFornecedorDataGridViewTextBoxColumn";
            this.refFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.refFornecedorDataGridViewTextBoxColumn.Width = 115;
            // 
            // qtdVendidaDataGridViewTextBoxColumn
            // 
            this.qtdVendidaDataGridViewTextBoxColumn.DataPropertyName = "QtdVendida";
            dataGridViewCellStyle11.Format = "N2";
            this.qtdVendidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.qtdVendidaDataGridViewTextBoxColumn.HeaderText = "Qtd vendida";
            this.qtdVendidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtdVendidaDataGridViewTextBoxColumn.Name = "qtdVendidaDataGridViewTextBoxColumn";
            this.qtdVendidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdVendidaDataGridViewTextBoxColumn.Width = 75;
            // 
            // precoVendaDataGridViewTextBoxColumn1
            // 
            this.precoVendaDataGridViewTextBoxColumn1.DataPropertyName = "PrecoVenda";
            dataGridViewCellStyle12.Format = "N2";
            this.precoVendaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.precoVendaDataGridViewTextBoxColumn1.HeaderText = "Preco de venda";
            this.precoVendaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.precoVendaDataGridViewTextBoxColumn1.Name = "precoVendaDataGridViewTextBoxColumn1";
            this.precoVendaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.precoVendaDataGridViewTextBoxColumn1.Width = 75;
            // 
            // totalVendidoDataGridViewTextBoxColumn
            // 
            this.totalVendidoDataGridViewTextBoxColumn.DataPropertyName = "TotalVendido";
            dataGridViewCellStyle13.Format = "N2";
            this.totalVendidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.totalVendidoDataGridViewTextBoxColumn.HeaderText = "Total vendido";
            this.totalVendidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalVendidoDataGridViewTextBoxColumn.Name = "totalVendidoDataGridViewTextBoxColumn";
            this.totalVendidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendidoDataGridViewTextBoxColumn.Width = 75;
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "PrecoProduto";
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.precoProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "Preco do produto";
            this.precoProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            this.precoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoProdutoDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dsPdtVenda;
            // 
            // dsPdtVenda
            // 
            this.dsPdtVenda.DataSetName = "dsPdtVenda";
            this.dsPdtVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPdtCompra
            // 
            this.dgvPdtCompra.AllowUserToAddRows = false;
            this.dgvPdtCompra.AllowUserToDeleteRows = false;
            this.dgvPdtCompra.AllowUserToOrderColumns = true;
            this.dgvPdtCompra.AutoGenerateColumns = false;
            this.dgvPdtCompra.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdtCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPdtCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPdtCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNFDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataLannDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.qtdCompraDataGridViewTextBoxColumn,
            this.totalcompraItemDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn});
            this.dgvPdtCompra.DataSource = this.dataTable1BindingSource1;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPdtCompra.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPdtCompra.Location = new System.Drawing.Point(11, 68);
            this.dgvPdtCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPdtCompra.MultiSelect = false;
            this.dgvPdtCompra.Name = "dgvPdtCompra";
            this.dgvPdtCompra.ReadOnly = true;
            this.dgvPdtCompra.RowHeadersWidth = 24;
            this.dgvPdtCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPdtCompra.Size = new System.Drawing.Size(980, 270);
            this.dgvPdtCompra.TabIndex = 5;
            // 
            // numeroNFDataGridViewTextBoxColumn
            // 
            this.numeroNFDataGridViewTextBoxColumn.DataPropertyName = "numeroNF";
            this.numeroNFDataGridViewTextBoxColumn.HeaderText = "N° Nota";
            this.numeroNFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroNFDataGridViewTextBoxColumn.Name = "numeroNFDataGridViewTextBoxColumn";
            this.numeroNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn.Width = 65;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data emissao";
            this.dataEmissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEmissaoDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataLannDataGridViewTextBoxColumn
            // 
            this.dataLannDataGridViewTextBoxColumn.DataPropertyName = "DataLann";
            this.dataLannDataGridViewTextBoxColumn.HeaderText = "Data lanç";
            this.dataLannDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLannDataGridViewTextBoxColumn.Name = "dataLannDataGridViewTextBoxColumn";
            this.dataLannDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLannDataGridViewTextBoxColumn.Width = 75;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornecedorDataGridViewTextBoxColumn.Width = 395;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 90;
            // 
            // qtdCompraDataGridViewTextBoxColumn
            // 
            this.qtdCompraDataGridViewTextBoxColumn.DataPropertyName = "QtdCompra";
            this.qtdCompraDataGridViewTextBoxColumn.HeaderText = "Qtd compra";
            this.qtdCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtdCompraDataGridViewTextBoxColumn.Name = "qtdCompraDataGridViewTextBoxColumn";
            this.qtdCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdCompraDataGridViewTextBoxColumn.Width = 65;
            // 
            // totalcompraItemDataGridViewTextBoxColumn
            // 
            this.totalcompraItemDataGridViewTextBoxColumn.DataPropertyName = "TotalcompraItem";
            this.totalcompraItemDataGridViewTextBoxColumn.HeaderText = "Total compra";
            this.totalcompraItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalcompraItemDataGridViewTextBoxColumn.Name = "totalcompraItemDataGridViewTextBoxColumn";
            this.totalcompraItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalcompraItemDataGridViewTextBoxColumn.Width = 90;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preço venda";
            this.precoVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoVendaDataGridViewTextBoxColumn.Width = 90;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dsPdtCompa;
            // 
            // dsPdtCompa
            // 
            this.dsPdtCompa.DataSetName = "dsPdtCompa";
            this.dsPdtCompa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vendas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data incial";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Descrição";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Pesquisar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // btnPesquisarEst
            // 
            this.btnPesquisarEst.Location = new System.Drawing.Point(900, 21);
            this.btnPesquisarEst.Name = "btnPesquisarEst";
            this.btnPesquisarEst.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarEst.TabIndex = 4;
            this.btnPesquisarEst.Text = "&Pesquisar";
            this.btnPesquisarEst.UseVisualStyleBackColor = true;
            this.btnPesquisarEst.Click += new System.EventHandler(this.BtnPesquisarEst_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1011, 687);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcPedidos.ResumeLayout(false);
            this.tbcPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPedidoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).EndInit();
            this.tbxEstoque.ResumeLayout(false);
            this.tbxEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtCompa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcPedidos;
        private System.Windows.Forms.Button btnVisualizar;
        public System.Windows.Forms.MaskedTextBox tbxIdCliente;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DateTimePicker tbxDataFin;
        public System.Windows.Forms.DateTimePicker tbxDataIni;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dsDgvPedidos dsDgvPedidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPedidosEnc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabPage tbxEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarEst;
        private System.Windows.Forms.DateTimePicker tbxDataFinEst;
        private System.Windows.Forms.DateTimePicker tbxDataIniEst;
        private System.Windows.Forms.DataGridView dgvPdtVenda;
        private System.Windows.Forms.DataGridView dgvPdtCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox tbxCodigo;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private dsPdtCompa dsPdtCompa;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private dsPdtVenda dsPdtVenda;
        private System.Windows.Forms.TextBox tbxTotalLiquid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxDescontos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxTotalBruto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxDataReg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxDataCad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxCondPag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvPedProdutos;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private PedidoProduto.dsPedidoProduto dsPedidoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoGeralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLiquidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn refFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVendidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLannDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcompraItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox tbxDescProduto;
        private System.Windows.Forms.ComboBox cbxPesquisarPor;
        private System.Windows.Forms.Label label18;
    }
}