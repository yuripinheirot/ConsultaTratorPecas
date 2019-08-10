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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcPedidos = new System.Windows.Forms.TabPage();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.tbxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbxDataFin = new System.Windows.Forms.DateTimePicker();
            this.tbxDataIni = new System.Windows.Forms.DateTimePicker();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDgvPedidos = new ConsultaTratorPecas.Main.dsDgvPedidos();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPedidosEnc = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tbxEstoque = new System.Windows.Forms.TabPage();
            this.tbxIdProduto = new System.Windows.Forms.MaskedTextBox();
            this.tbxDataFinEst = new System.Windows.Forms.DateTimePicker();
            this.tbxDataIniEst = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvPdtCompra = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarEst = new System.Windows.Forms.Button();
            this.dsPdtCompa = new ConsultaTratorPecas.Main.dsPdtCompa();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numeroNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLannDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcompraItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbcPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).BeginInit();
            this.tbxEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtCompa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcPedidos);
            this.tabControl1.Controls.Add(this.tbxEstoque);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 897);
            this.tabControl1.TabIndex = 0;
            // 
            // tbcPedidos
            // 
            this.tbcPedidos.Controls.Add(this.btnVisualizar);
            this.tbcPedidos.Controls.Add(this.tbxIdCliente);
            this.tbcPedidos.Controls.Add(this.btnPesquisar);
            this.tbcPedidos.Controls.Add(this.tbxDataFin);
            this.tbcPedidos.Controls.Add(this.tbxDataIni);
            this.tbcPedidos.Controls.Add(this.dgvPedidos);
            this.tbcPedidos.Controls.Add(this.label6);
            this.tbcPedidos.Controls.Add(this.label3);
            this.tbcPedidos.Controls.Add(this.label4);
            this.tbcPedidos.Controls.Add(this.tbxNomeCliente);
            this.tbcPedidos.Controls.Add(this.label5);
            this.tbcPedidos.Controls.Add(this.lblPedidosEnc);
            this.tbcPedidos.Controls.Add(this.btnSair);
            this.tbcPedidos.Location = new System.Drawing.Point(4, 25);
            this.tbcPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbcPedidos.Name = "tbcPedidos";
            this.tbcPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.tbcPedidos.Size = new System.Drawing.Size(1340, 868);
            this.tbcPedidos.TabIndex = 0;
            this.tbcPedidos.Text = "Pedidos";
            this.tbcPedidos.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(1113, 818);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(100, 28);
            this.btnVisualizar.TabIndex = 20;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // tbxIdCliente
            // 
            this.tbxIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdCliente.Location = new System.Drawing.Point(15, 27);
            this.tbxIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIdCliente.Mask = "000000";
            this.tbxIdCliente.Name = "tbxIdCliente";
            this.tbxIdCliente.PromptChar = ' ';
            this.tbxIdCliente.Size = new System.Drawing.Size(88, 23);
            this.tbxIdCliente.TabIndex = 8;
            this.tbxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdCliente.TextChanged += new System.EventHandler(this.TbxIdCliente_TextChanged);
            this.tbxIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdCliente_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(893, 26);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // tbxDataFin
            // 
            this.tbxDataFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataFin.Location = new System.Drawing.Point(757, 27);
            this.tbxDataFin.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataFin.Name = "tbxDataFin";
            this.tbxDataFin.Size = new System.Drawing.Size(127, 22);
            this.tbxDataFin.TabIndex = 16;
            // 
            // tbxDataIni
            // 
            this.tbxDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIni.Location = new System.Drawing.Point(620, 27);
            this.tbxDataIni.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataIni.Name = "tbxDataIni";
            this.tbxDataIni.Size = new System.Drawing.Size(127, 22);
            this.tbxDataIni.TabIndex = 10;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToOrderColumns = true;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(15, 84);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1307, 720);
            this.dgvPedidos.TabIndex = 18;
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
            this.dataCadastroDataGridViewTextBoxColumn.Width = 125;
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
            this.vendedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome";
            // 
            // tbxNomeCliente
            // 
            this.tbxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomeCliente.Location = new System.Drawing.Point(112, 27);
            this.tbxNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNomeCliente.Name = "tbxNomeCliente";
            this.tbxNomeCliente.ReadOnly = true;
            this.tbxNomeCliente.Size = new System.Drawing.Size(499, 23);
            this.tbxNomeCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data inicial";
            // 
            // lblPedidosEnc
            // 
            this.lblPedidosEnc.AutoSize = true;
            this.lblPedidosEnc.Location = new System.Drawing.Point(9, 63);
            this.lblPedidosEnc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidosEnc.Name = "lblPedidosEnc";
            this.lblPedidosEnc.Size = new System.Drawing.Size(150, 17);
            this.lblPedidosEnc.TabIndex = 15;
            this.lblPedidosEnc.Text = "Pedidos encontrados: ";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(1221, 818);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 28);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tbxEstoque
            // 
            this.tbxEstoque.Controls.Add(this.tbxIdProduto);
            this.tbxEstoque.Controls.Add(this.tbxDataFinEst);
            this.tbxEstoque.Controls.Add(this.tbxDataIniEst);
            this.tbxEstoque.Controls.Add(this.dataGridView2);
            this.tbxEstoque.Controls.Add(this.dgvPdtCompra);
            this.tbxEstoque.Controls.Add(this.label8);
            this.tbxEstoque.Controls.Add(this.label9);
            this.tbxEstoque.Controls.Add(this.label7);
            this.tbxEstoque.Controls.Add(this.label2);
            this.tbxEstoque.Controls.Add(this.label1);
            this.tbxEstoque.Controls.Add(this.btnPesquisarEst);
            this.tbxEstoque.Location = new System.Drawing.Point(4, 25);
            this.tbxEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEstoque.Name = "tbxEstoque";
            this.tbxEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.tbxEstoque.Size = new System.Drawing.Size(1340, 868);
            this.tbxEstoque.TabIndex = 1;
            this.tbxEstoque.Text = "Estoque";
            this.tbxEstoque.UseVisualStyleBackColor = true;
            // 
            // tbxIdProduto
            // 
            this.tbxIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdProduto.Location = new System.Drawing.Point(14, 28);
            this.tbxIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIdProduto.Mask = "000000";
            this.tbxIdProduto.Name = "tbxIdProduto";
            this.tbxIdProduto.PromptChar = ' ';
            this.tbxIdProduto.Size = new System.Drawing.Size(88, 23);
            this.tbxIdProduto.TabIndex = 9;
            this.tbxIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxProdutoEst_KeyDown);
            // 
            // tbxDataFinEst
            // 
            this.tbxDataFinEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataFinEst.Location = new System.Drawing.Point(245, 27);
            this.tbxDataFinEst.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataFinEst.Name = "tbxDataFinEst";
            this.tbxDataFinEst.Size = new System.Drawing.Size(125, 22);
            this.tbxDataFinEst.TabIndex = 2;
            // 
            // tbxDataIniEst
            // 
            this.tbxDataIniEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIniEst.Location = new System.Drawing.Point(110, 27);
            this.tbxDataIniEst.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataIniEst.Name = "tbxDataIniEst";
            this.tbxDataIniEst.Size = new System.Drawing.Size(125, 22);
            this.tbxDataIniEst.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(15, 446);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1307, 332);
            this.dataGridView2.TabIndex = 5;
            // 
            // dgvPdtCompra
            // 
            this.dgvPdtCompra.AllowUserToAddRows = false;
            this.dgvPdtCompra.AllowUserToDeleteRows = false;
            this.dgvPdtCompra.AllowUserToOrderColumns = true;
            this.dgvPdtCompra.AutoGenerateColumns = false;
            this.dgvPdtCompra.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPdtCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPdtCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPdtCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNFDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.dataLannDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.qtdCompraDataGridViewTextBoxColumn,
            this.totalcompraItemDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn});
            this.dgvPdtCompra.DataSource = this.dataTable1BindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPdtCompra.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPdtCompra.Location = new System.Drawing.Point(15, 84);
            this.dgvPdtCompra.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPdtCompra.MultiSelect = false;
            this.dgvPdtCompra.Name = "dgvPdtCompra";
            this.dgvPdtCompra.ReadOnly = true;
            this.dgvPdtCompra.RowHeadersWidth = 24;
            this.dgvPdtCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPdtCompra.Size = new System.Drawing.Size(1307, 332);
            this.dgvPdtCompra.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vendas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data incial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // btnPesquisarEst
            // 
            this.btnPesquisarEst.Location = new System.Drawing.Point(380, 25);
            this.btnPesquisarEst.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarEst.Name = "btnPesquisarEst";
            this.btnPesquisarEst.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisarEst.TabIndex = 3;
            this.btnPesquisarEst.Text = "&Pesquisar";
            this.btnPesquisarEst.UseVisualStyleBackColor = true;
            this.btnPesquisarEst.Click += new System.EventHandler(this.BtnPesquisarEst_Click);
            // 
            // dsPdtCompa
            // 
            this.dsPdtCompa.DataSetName = "dsPdtCompa";
            this.dsPdtCompa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dsPdtCompa;
            // 
            // numeroNFDataGridViewTextBoxColumn
            // 
            this.numeroNFDataGridViewTextBoxColumn.DataPropertyName = "numeroNF";
            this.numeroNFDataGridViewTextBoxColumn.HeaderText = "N° Nota";
            this.numeroNFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroNFDataGridViewTextBoxColumn.Name = "numeroNFDataGridViewTextBoxColumn";
            this.numeroNFDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 65;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data emissao";
            this.dataEmissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEmissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataLannDataGridViewTextBoxColumn
            // 
            this.dataLannDataGridViewTextBoxColumn.DataPropertyName = "DataLann";
            this.dataLannDataGridViewTextBoxColumn.HeaderText = "Data lanç";
            this.dataLannDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLannDataGridViewTextBoxColumn.Name = "dataLannDataGridViewTextBoxColumn";
            this.dataLannDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLannDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornecedorDataGridViewTextBoxColumn.Width = 250;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 250;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 125;
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
            this.totalcompraItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preço venda";
            this.precoVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1348, 897);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbcPedidos.ResumeLayout(false);
            this.tbcPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).EndInit();
            this.tbxEstoque.ResumeLayout(false);
            this.tbxEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPdtCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPdtCompa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvPdtCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox tbxIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLannDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcompraItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private dsPdtCompa dsPdtCompa;
    }
}