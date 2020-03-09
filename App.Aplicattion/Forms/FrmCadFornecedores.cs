using App.Aplicattion.Utils;
using App.Domain.Entity;
using App.Service.Services.Fornecedor;
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
    public partial class FrmCadFornecedores : Form
    {
        IFornecedorService _fornecedorService;
        IEnumerable<FornecedorEntity> _fornecedoresLista;
        FornecedorEntity _fornecedor;
        public FrmCadFornecedores()
        {
            InitializeComponent();
            _fornecedorService = new FornecedorService();

        }

        void CarregarListaFornecedor(string filtro = "")
        {
            _fornecedoresLista = string.IsNullOrWhiteSpace(filtro) ? 
                _fornecedorService.GetAll()
                : _fornecedorService.GetAll().Where(f =>
                f.Nome.Contains(filtro) || f.Cnpj.Contains(filtro) || f.Endereco.Contains(filtro)
            );
            bsFornecedorLista.DataSource = _fornecedoresLista;
        }

        void CarregarCadastroFornecedor(int id = 0)
        {
            _fornecedor = _fornecedorService.Get(id);
            bsCadastro.DataSource = _fornecedor;
        }

        void AlterarForcedor()
        {
            try
            {
                if (dgvFornecedor.SelectedRows.Count > 0)
                {
                    int Id = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells["FornecedorIdDgvC"].Value);
                    CarregarCadastroFornecedor(Id);
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtCnpj.Text))
            {
                error.SetError(txtCnpj, "A senha do usuário é obrigatória!");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                error.SetError(txtEndereco, "A senha do usuário é obrigatória!");
                retorno = false;
            }

            return retorno;
        }

        private void FrmCadFornecedores_Shown(object sender, EventArgs e)
        {
            CarregarListaFornecedor();
            CarregarCadastroFornecedor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("É obrigatório selecionar um fornecedor!");
                }
                else
                {
                    if (MessageBox.Show("Confirma exclusão?", "Excluir Fornecedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells["FornecedorIdDgvC"].Value);
                        if (_fornecedorService.Delete(Id))
                        {
                            CarregarListaFornecedor();
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
                CarregarCadastroFornecedor();
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
                if (MsgBox.Confirmar("Cancelar cadastro do Fornecedor?", "Confirmar cancelamento"))
                {
                    CarregarCadastroFornecedor();
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
                if (IsValid() && MsgBox.Confirmar("Salvar o cadastro Fornecedor?", "Salvar Fornecedor"))
                {
                    FornecedorEntity fornecedor = new FornecedorEntity
                    {
                        Id = _fornecedor.Id, 
                        Nome = txtNome.Text,
                        Cnpj = txtCnpj.Text,
                        Endereco = txtEndereco.Text,
                        Ativo = chkAtivo.Checked
                    };

                    if (fornecedor.Id == 0)
                    { fornecedor = _fornecedorService.Post(fornecedor); }
                    else
                    { fornecedor = _fornecedorService.Put(fornecedor); }

                    CarregarListaFornecedor();
                    CarregarCadastroFornecedor();
                    tcCadastro.SelectedTab = tpConsulta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException);
            }
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarForcedor();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CarregarListaFornecedor(txtPesquisa.Text);
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            { SelectNextControl(sender as Control, true, true, true, true); }
        }

        private void FrmCadFornecedores_KeyUp(object sender, KeyEventArgs e)
        {
            if (tcCadastro.SelectedTab == tpCadastro)
            {
                if (e.KeyCode == Keys.Escape)
                { btnCancelar.PerformClick(); }
            }
        }
    }
}
