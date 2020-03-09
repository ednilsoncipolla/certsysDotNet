using App.Aplicattion;
using App.Domain.Entity;
using App.Service.Services.User;
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
    public partial class FrmLogin : Form
    {
        int tentativa = 0;
        UsuarioService _usuarioService;
        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private bool IsValid()
        {
            bool retorno = true;

            error.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                error.SetError(txtUsuario, "Identificação do usuário é obrigatória!");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                error.SetError(txtSenha, "A senha do usuário é obrigatória!");
                retorno = false;
            }

            return retorno;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                tentativa += 1;
                Cursor cursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                UsuarioEntity usuario = _usuarioService.GetAll()
                    .Where(u => u.Login == txtUsuario.Text.Trim() && u.Login == txtUsuario.Text.Trim()).FirstOrDefault();
                this.Cursor = cursor;

                if (usuario == null)
                {
                    MessageBox.Show("Usuário ou senha inválida!");

                    if (tentativa == 3)
                        btnSair.PerformClick();
                }
                else
                {
                    if (usuario.Ativo)
                    {
                        AppDotNetContext.Usuario = usuario;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Usuário inativo!\nTente novamente!");
                    }
                }

            }
            else
                txtUsuario.Focus();
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void FrmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnSair.PerformClick();
        }
    }
}
