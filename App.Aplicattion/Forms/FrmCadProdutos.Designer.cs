namespace App.View
{
    partial class FrmCadProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcCadastro = new System.Windows.Forms.TabControl();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.ProdutoIdDgvC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProdutoLista = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.nmrQuantidade = new System.Windows.Forms.NumericUpDown();
            this.bsCadastro = new System.Windows.Forms.BindingSource(this.components);
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcCadastro.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoLista)).BeginInit();
            this.tpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCadastro
            // 
            this.tcCadastro.Controls.Add(this.tpConsulta);
            this.tcCadastro.Controls.Add(this.tpCadastro);
            this.tcCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCadastro.Location = new System.Drawing.Point(0, 0);
            this.tcCadastro.Name = "tcCadastro";
            this.tcCadastro.SelectedIndex = 0;
            this.tcCadastro.Size = new System.Drawing.Size(858, 450);
            this.tcCadastro.TabIndex = 1;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.btnNovo);
            this.tpConsulta.Controls.Add(this.btnExcluir);
            this.tpConsulta.Controls.Add(this.dgvProduto);
            this.tpConsulta.Controls.Add(this.txtPesquisa);
            this.tpConsulta.Controls.Add(this.lblPesquisar);
            this.tpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConsulta.Location = new System.Drawing.Point(4, 33);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(850, 413);
            this.tpConsulta.TabIndex = 0;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(730, 373);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 32);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(18, 373);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 32);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoIdDgvC,
            this.nomeDataGridViewTextBoxColumn,
            this.fornecedorNomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.fornecedorIdDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.bsProdutoLista;
            this.dgvProduto.Location = new System.Drawing.Point(18, 78);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(816, 289);
            this.dgvProduto.TabIndex = 2;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            // 
            // ProdutoIdDgvC
            // 
            this.ProdutoIdDgvC.DataPropertyName = "Id";
            this.ProdutoIdDgvC.HeaderText = "Id";
            this.ProdutoIdDgvC.Name = "ProdutoIdDgvC";
            this.ProdutoIdDgvC.ReadOnly = true;
            this.ProdutoIdDgvC.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do produto";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.ToolTipText = "Nome do produto";
            this.nomeDataGridViewTextBoxColumn.Width = 400;
            // 
            // fornecedorNomeDataGridViewTextBoxColumn
            // 
            this.fornecedorNomeDataGridViewTextBoxColumn.DataPropertyName = "FornecedorNome";
            this.fornecedorNomeDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorNomeDataGridViewTextBoxColumn.Name = "fornecedorNomeDataGridViewTextBoxColumn";
            this.fornecedorNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornecedorNomeDataGridViewTextBoxColumn.ToolTipText = "Nome do fornecedor";
            this.fornecedorNomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorIdDataGridViewTextBoxColumn
            // 
            this.fornecedorIdDataGridViewTextBoxColumn.DataPropertyName = "FornecedorId";
            this.fornecedorIdDataGridViewTextBoxColumn.HeaderText = "FornecedorId";
            this.fornecedorIdDataGridViewTextBoxColumn.Name = "fornecedorIdDataGridViewTextBoxColumn";
            this.fornecedorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fornecedorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsProdutoLista
            // 
            this.bsProdutoLista.DataSource = typeof(App.Domain.Dto.ProdutoDto);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(141, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(560, 26);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(56, 32);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(79, 20);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.nmrQuantidade);
            this.tpCadastro.Controls.Add(this.cbFornecedor);
            this.tpCadastro.Controls.Add(this.btnSalvar);
            this.tpCadastro.Controls.Add(this.btnCancelar);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCadastro.Location = new System.Drawing.Point(4, 33);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(850, 413);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // nmrQuantidade
            // 
            this.nmrQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCadastro, "Quantidade", true));
            this.nmrQuantidade.Location = new System.Drawing.Point(176, 116);
            this.nmrQuantidade.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmrQuantidade.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.nmrQuantidade.Name = "nmrQuantidade";
            this.nmrQuantidade.Size = new System.Drawing.Size(120, 26);
            this.nmrQuantidade.TabIndex = 5;
            this.nmrQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.nmrQuantidade, "Quantidade do produto");
            this.nmrQuantidade.Enter += new System.EventHandler(this.Control_Enter);
            this.nmrQuantidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.nmrQuantidade.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // bsCadastro
            // 
            this.bsCadastro.DataSource = typeof(App.Domain.Dto.ProdutoDto);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsCadastro, "FornecedorId", true));
            this.cbFornecedor.DisplayMember = "Nome";
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(176, 83);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(559, 28);
            this.cbFornecedor.TabIndex = 3;
            this.toolTip.SetToolTip(this.cbFornecedor, "Fornecedor do produto");
            this.cbFornecedor.ValueMember = "Id";
            this.cbFornecedor.Enter += new System.EventHandler(this.Control_Enter);
            this.cbFornecedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.cbFornecedor.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(631, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 32);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.toolTip.SetToolTip(this.btnSalvar, "Confirmar informações lançadas e salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(94, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.toolTip.SetToolTip(this.btnCancelar, "Descartar informações lançadas e cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCadastro, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(176, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(560, 26);
            this.txtNome.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtNome, "Nome do produto");
            this.txtNome.Enter += new System.EventHandler(this.Control_Enter);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.txtNome.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FrmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.tcCadastro);
            this.Name = "FrmCadProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadProdutos";
            this.Shown += new System.EventHandler(this.FrmCadProdutos_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCadProdutos_KeyUp);
            this.tcCadastro.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutoLista)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCadastro;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.BindingSource bsCadastro;
        private System.Windows.Forms.BindingSource bsProdutoLista;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.NumericUpDown nmrQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoIdDgvC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorIdDataGridViewTextBoxColumn;
    }
}