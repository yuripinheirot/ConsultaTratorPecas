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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tbxProdutoEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarEst = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvComprasEst = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbxDataIniEst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDataFinEst = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tbcPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).BeginInit();
            this.tbxEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1011, 729);
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
            this.tbcPedidos.Location = new System.Drawing.Point(4, 22);
            this.tbcPedidos.Name = "tbcPedidos";
            this.tbcPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPedidos.Size = new System.Drawing.Size(1003, 703);
            this.tbcPedidos.TabIndex = 0;
            this.tbcPedidos.Text = "Pedidos";
            this.tbcPedidos.UseVisualStyleBackColor = true;
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
            this.tbxIdCliente.TabIndex = 8;
            this.tbxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdCliente.TextChanged += new System.EventHandler(this.TbxIdCliente_TextChanged);
            this.tbxIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdCliente_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(670, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
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
            this.tbxDataFin.TabIndex = 16;
            // 
            // tbxDataIni
            // 
            this.tbxDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIni.Location = new System.Drawing.Point(465, 22);
            this.tbxDataIni.Name = "tbxDataIni";
            this.tbxDataIni.Size = new System.Drawing.Size(96, 20);
            this.tbxDataIni.TabIndex = 10;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToOrderColumns = true;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 68);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(980, 585);
            this.dgvPedidos.TabIndex = 18;
            this.dgvPedidos.DoubleClick += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 450;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total venda";
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tbxNomeCliente.TabIndex = 9;
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
            this.btnSair.Location = new System.Drawing.Point(916, 665);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tbxEstoque
            // 
            this.tbxEstoque.Controls.Add(this.tbxDataFinEst);
            this.tbxEstoque.Controls.Add(this.tbxDataIniEst);
            this.tbxEstoque.Controls.Add(this.dataGridView2);
            this.tbxEstoque.Controls.Add(this.dgvComprasEst);
            this.tbxEstoque.Controls.Add(this.tbxProdutoEst);
            this.tbxEstoque.Controls.Add(this.label8);
            this.tbxEstoque.Controls.Add(this.label9);
            this.tbxEstoque.Controls.Add(this.label7);
            this.tbxEstoque.Controls.Add(this.label2);
            this.tbxEstoque.Controls.Add(this.label1);
            this.tbxEstoque.Controls.Add(this.btnPesquisarEst);
            this.tbxEstoque.Location = new System.Drawing.Point(4, 22);
            this.tbxEstoque.Name = "tbxEstoque";
            this.tbxEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbxEstoque.Size = new System.Drawing.Size(1003, 703);
            this.tbxEstoque.TabIndex = 1;
            this.tbxEstoque.Text = "Estoque";
            this.tbxEstoque.UseVisualStyleBackColor = true;
            // 
            // tbxProdutoEst
            // 
            this.tbxProdutoEst.Location = new System.Drawing.Point(11, 22);
            this.tbxProdutoEst.Name = "tbxProdutoEst";
            this.tbxProdutoEst.Size = new System.Drawing.Size(134, 20);
            this.tbxProdutoEst.TabIndex = 0;
            this.tbxProdutoEst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxProdutoEst_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // btnPesquisarEst
            // 
            this.btnPesquisarEst.Location = new System.Drawing.Point(353, 20);
            this.btnPesquisarEst.Name = "btnPesquisarEst";
            this.btnPesquisarEst.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarEst.TabIndex = 3;
            this.btnPesquisarEst.Text = "&Pesquisar";
            this.btnPesquisarEst.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vendas";
            // 
            // dgvComprasEst
            // 
            this.dgvComprasEst.AllowUserToAddRows = false;
            this.dgvComprasEst.AllowUserToDeleteRows = false;
            this.dgvComprasEst.AllowUserToOrderColumns = true;
            this.dgvComprasEst.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprasEst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvComprasEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasEst.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvComprasEst.Location = new System.Drawing.Point(11, 68);
            this.dgvComprasEst.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComprasEst.MultiSelect = false;
            this.dgvComprasEst.Name = "dgvComprasEst";
            this.dgvComprasEst.ReadOnly = true;
            this.dgvComprasEst.RowHeadersWidth = 24;
            this.dgvComprasEst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasEst.Size = new System.Drawing.Size(980, 270);
            this.dgvComprasEst.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(11, 362);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(980, 270);
            this.dataGridView2.TabIndex = 5;
            // 
            // tbxDataIniEst
            // 
            this.tbxDataIniEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataIniEst.Location = new System.Drawing.Point(151, 22);
            this.tbxDataIniEst.Name = "tbxDataIniEst";
            this.tbxDataIniEst.Size = new System.Drawing.Size(95, 20);
            this.tbxDataIniEst.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data incial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data final";
            // 
            // tbxDataFinEst
            // 
            this.tbxDataFinEst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataFinEst.Location = new System.Drawing.Point(252, 22);
            this.tbxDataFinEst.Name = "tbxDataFinEst";
            this.tbxDataFinEst.Size = new System.Drawing.Size(95, 20);
            this.tbxDataFinEst.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1011, 729);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDgvPedidos)).EndInit();
            this.tbxEstoque.ResumeLayout(false);
            this.tbxEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox tbxProdutoEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarEst;
        private System.Windows.Forms.DateTimePicker tbxDataFinEst;
        private System.Windows.Forms.DateTimePicker tbxDataIniEst;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvComprasEst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}