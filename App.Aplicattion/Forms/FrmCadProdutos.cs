using App.Aplicattion.Utils;
using App.Domain.Dto;
using App.Domain.Entity;
using App.Service.Services.Fornecedor;
using App.Service.Services.Produto;
using App.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.View
{
    public partial class FrmCadProdutos : Form
    {
        ProdutoService _produtoServices;
        FornecedorService _fornecedorServices;
        IEnumerable<ProdutoDto> _produtoDtoLista;
        ProdutoDto _produtoDto;
        IList<FornecedorEntity> _fornecedorLista;

        public FrmCadProdutos()
        {
            InitializeComponent();
            _produtoServices = new ProdutoService();
            _fornecedorServices = new FornecedorService();
            _produtoDtoLista = new List<ProdutoDto>();
            _produtoDto = new ProdutoDto();
            _fornecedorLista = new List<FornecedorEntity>();
            cbFornecedor.DataSource = null;
        }

        void CarregarProdutoDto(int id = 0)
        {
            _produtoDto = _produtoServices.GetDto(id);
            bsCadastro.DataSource = _produtoDto;
        }

        void CarregarProdutoDtoLista(string filtro = "")
        {
            _produtoDtoLista = string.IsNullOrWhiteSpace(filtro) ?
                _produtoServices.GetAllDto()
                : _produtoServices.GetAllDto()
                    .Where(p => p.Nome.Contains(filtro)
                        || p.FornecedorNome.Contains(filtro)
                        );
            bsProdutoLista.DataSource = _produtoDtoLista;
        }

        void CarregaFornecedorLista()
        {
            _fornecedorLista = _fornecedorServices.GetAll().Where(f => f.Ativo = true).ToList();
            cbFornecedor.DataSource = _fornecedorLista;
            cbFornecedor.ValueMember = "Id";
            cbFornecedor.DisplayMember = "Nome";
        }

        void AlterarProduto()
        {
            try
            {
                if (dgvProduto.SelectedRows.Count > 0)
                {
                    CarregaFornecedorLista();
                    int Id = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells["ProdutoIdDgvC"].Value);
                    CarregarProdutoDto(Id);
                    tcCadastro.SelectedTab = tpCadastro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        public void Control_Enter(object sender, EventArgs e)
        {
            ControlController.OnEnter(sender, e, toolTip);
        }

        public void Control_Leave(object sender, EventArgs e)
        {
            ControlController.OnLeave(sender, e, toolTip);
        }

        private void dgvProduto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                e.CellStyle.BackColor = e.RowIndex % 2 == 0 ? SystemColors.Window : SystemColors.Control;
            }
        }

        private bool IsValid()
        {
            bool retorno = true;

            error.Clear();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                error.SetError(txtNome, "Identificação do usuário é obrigatória!");
                retorno = false;
            }

            if (cbFornecedor.SelectedItem == null)
            {
                error.SetError(cbFornecedor, "É obrigatório selecionar um fornecedor!");
                retorno = false;
            }

            return retorno;
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarProduto();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CarregarProdutoDtoLista(txtPesquisa.Text);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("É obrigatório selecionar um fornecedor!");
                }
                else
                {
                    if (MessageBox.Show("Confirma exclusão?", "Excluir Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells["ProdutoIdDgvC"].Value);
                        if (_produtoServices.Delete(Id))
                        {
                            CarregarProdutoDtoLista();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarProdutoDto();
                CarregaFornecedorLista();
                tcCadastro.SelectedTab = tpCadastro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgBox.Confirmar("Cancelar cadastro do Produto?", "Confirmar cancelamento"))
                {
                    CarregarProdutoDto();
                    cbFornecedor.DataSource = null;
                    tcCadastro.SelectedTab = tpConsulta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid() && MsgBox.Confirmar("Salvar o cadastro do Produto?", "Salvar Produto"))
                {
                    ProdutoDto produto = new ProdutoDto()
                    {
                        Id = _produtoDto.Id,
                        Nome = txtNome.Text,
                        FornecedorId = Convert.ToInt32(cbFornecedor.SelectedValue),
                        FornecedorNome = cbFornecedor.Text,
                        Quantidade = nmrQuantidade.Value
                    };

                    if (produto.Id == 0)
                    { produto = _produtoServices.PostDto(produto); }
                    else
                    { produto = _produtoServices.PutDto(produto); }

                    CarregarProdutoDtoLista();
                    CarregarProdutoDto();
                    tcCadastro.SelectedTab = tpConsulta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void FrmCadProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            if (tcCadastro.SelectedTab == tpCadastro)
            {
                if (e.KeyCode == Keys.Escape)
                { btnCancelar.PerformClick(); }
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            { SelectNextControl(sender as Control, true, true, true, true); }

        }

        private void FrmCadProdutos_Shown(object sender, EventArgs e)
        {
            CarregarProdutoDtoLista();
        }
    }
}
