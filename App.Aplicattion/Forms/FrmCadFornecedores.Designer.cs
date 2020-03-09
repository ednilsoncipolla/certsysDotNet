namespace App.View
{
    partial class FrmCadFornecedores
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
            this.tcCadastro = new System.Windows.Forms.TabControl();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ednderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorIdDgvC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsFornecedorLista = new System.Windows.Forms.BindingSource(this.components);
            this.bsCadastro = new System.Windows.Forms.BindingSource(this.components);
            this.tcCadastro.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.tpCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadastro)).BeginInit();
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
            this.tcCadastro.Size = new System.Drawing.Size(864, 450);
            this.tcCadastro.TabIndex = 0;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.btnNovo);
            this.tpConsulta.Controls.Add(this.btnExcluir);
            this.tpConsulta.Controls.Add(this.dgvFornecedor);
            this.tpConsulta.Controls.Add(this.txtPesquisa);
            this.tpConsulta.Controls.Add(this.lblPesquisar);
            this.tpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConsulta.Location = new System.Drawing.Point(4, 33);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(856, 413);
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
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToResizeColumns = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.ednderecoDataGridViewTextBoxColumn,
            this.FornecedorIdDgvC,
            this.createdAtDataGridViewTextBoxColumn,
            this.updateAtDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.dgvFornecedor.DataSource = this.bsFornecedorLista;
            this.dgvFornecedor.Location = new System.Drawing.Point(18, 78);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(816, 289);
            this.dgvFornecedor.TabIndex = 2;
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            this.dgvFornecedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
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
            this.tpCadastro.Controls.Add(this.btnSalvar);
            this.tpCadastro.Controls.Add(this.btnCancelar);
            this.tpCadastro.Controls.Add(this.chkAtivo);
            this.tpCadastro.Controls.Add(this.txtEndereco);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.txtCnpj);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtNome);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCadastro.Location = new System.Drawing.Point(4, 33);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(856, 413);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(631, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 32);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.toolTip.SetToolTip(this.btnSalvar, "Confirmar as informações lançadas e Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(94, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.toolTip.SetToolTip(this.btnCancelar, "Descartar as informações lançadas");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCadastro, "Ativo", true));
            this.chkAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCadastro, "Ativo", true));
            this.chkAtivo.Location = new System.Drawing.Point(175, 147);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(63, 24);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "&Ativo";
            this.toolTip.SetToolTip(this.chkAtivo, "Status do Fornecedor");
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.Enter += new System.EventHandler(this.Control_Enter);
            this.chkAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.chkAtivo.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCadastro, "Endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(175, 115);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(560, 26);
            this.txtEndereco.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtEndereco, "Endereço do Fornecedor");
            this.txtEndereco.Enter += new System.EventHandler(this.Control_Enter);
            this.txtEndereco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.txtEndereco.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Endereço";
            // 
            // txtCnpj
            // 
            this.txtCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCadastro, "Cnpj", true));
            this.txtCnpj.Location = new System.Drawing.Point(175, 83);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(560, 26);
            this.txtCnpj.TabIndex = 3;
            this.toolTip.SetToolTip(this.txtCnpj, "CNPJ do Fornecedor");
            this.txtCnpj.Enter += new System.EventHandler(this.Control_Enter);
            this.txtCnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.txtCnpj.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "C&NPJ";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCadastro, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(175, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(560, 26);
            this.txtNome.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtNome, "Nome do Fornecedor");
            this.txtNome.Enter += new System.EventHandler(this.Control_Enter);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            this.txtNome.Leave += new System.EventHandler(this.Control_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 240;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "Cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnpjDataGridViewTextBoxColumn.Width = 180;
            // 
            // ednderecoDataGridViewTextBoxColumn
            // 
            this.ednderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.ednderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.ednderecoDataGridViewTextBoxColumn.Name = "ednderecoDataGridViewTextBoxColumn";
            this.ednderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ednderecoDataGridViewTextBoxColumn.Width = 280;
            // 
            // FornecedorIdDgvC
            // 
            this.FornecedorIdDgvC.DataPropertyName = "Id";
            this.FornecedorIdDgvC.HeaderText = "Id";
            this.FornecedorIdDgvC.Name = "FornecedorIdDgvC";
            this.FornecedorIdDgvC.ReadOnly = true;
            this.FornecedorIdDgvC.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateAtDataGridViewTextBoxColumn
            // 
            this.updateAtDataGridViewTextBoxColumn.DataPropertyName = "UpdateAt";
            this.updateAtDataGridViewTextBoxColumn.HeaderText = "UpdateAt";
            this.updateAtDataGridViewTextBoxColumn.Name = "updateAtDataGridViewTextBoxColumn";
            this.updateAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // bsFornecedorLista
            // 
            this.bsFornecedorLista.DataSource = typeof(App.Domain.Entity.FornecedorEntity);
            // 
            // bsCadastro
            // 
            this.bsCadastro.DataSource = typeof(App.Domain.Entity.FornecedorEntity);
            // 
            // FrmCadFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.tcCadastro);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadFornecedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Shown += new System.EventHandler(this.FrmCadFornecedores_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCadFornecedores_KeyUp);
            this.tcCadastro.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFornecedorLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCadastro;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.BindingSource bsCadastro;
        private System.Windows.Forms.BindingSource bsFornecedorLista;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ednderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorIdDgvC;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip;
    }
}