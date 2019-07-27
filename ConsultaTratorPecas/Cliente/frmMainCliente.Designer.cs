namespace ConsultaTratorPecas.Cliente
{
    partial class frmMainCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblClientesEnc = new System.Windows.Forms.Label();
            this.tbxPalavra = new System.Windows.Forms.TextBox();
            this.cbxPesquisar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tratorDataSet = new ConsultaTratorPecas.TratorDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new ConsultaTratorPecas.TratorDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(712, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCliente.Location = new System.Drawing.Point(12, 26);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(775, 320);
            this.dgvCliente.TabIndex = 3;
            // 
            // lblClientesEnc
            // 
            this.lblClientesEnc.AutoSize = true;
            this.lblClientesEnc.Location = new System.Drawing.Point(9, 9);
            this.lblClientesEnc.Name = "lblClientesEnc";
            this.lblClientesEnc.Size = new System.Drawing.Size(109, 13);
            this.lblClientesEnc.TabIndex = 18;
            this.lblClientesEnc.Text = "Clientes encontrados:";
            // 
            // tbxPalavra
            // 
            this.tbxPalavra.Location = new System.Drawing.Point(12, 418);
            this.tbxPalavra.Name = "tbxPalavra";
            this.tbxPalavra.Size = new System.Drawing.Size(217, 20);
            this.tbxPalavra.TabIndex = 0;
            this.tbxPalavra.TextChanged += new System.EventHandler(this.TbxPalavra_TextChanged);
            this.tbxPalavra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbcPalavra_KeyDown);
            // 
            // cbxPesquisar
            // 
            this.cbxPesquisar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPesquisar.FormattingEnabled = true;
            this.cbxPesquisar.Items.AddRange(new object[] {
            "Nome",
            "CPF/CNPJ"});
            this.cbxPesquisar.Location = new System.Drawing.Point(12, 378);
            this.cbxPesquisar.Name = "cbxPesquisar";
            this.cbxPesquisar.Size = new System.Drawing.Size(217, 21);
            this.cbxPesquisar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Palavra chave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pesquisar por";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(631, 415);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // tratorDataSet
            // 
            this.tratorDataSet.DataSetName = "TratorDataSet";
            this.tratorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.tratorDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMainCliente
            // 
            this.AcceptButton = this.btnInserir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cbxPesquisar);
            this.Controls.Add(this.tbxPalavra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClientesEnc);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMainCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmMainCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblClientesEnc;
        private System.Windows.Forms.TextBox tbxPalavra;
        private System.Windows.Forms.ComboBox cbxPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserir;
        private TratorDataSet tratorDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private TratorDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}