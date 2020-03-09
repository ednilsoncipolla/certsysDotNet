using App.Aplicattion;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            if (AppDotNetContext.Usuario == null)
            {
                FrmLogin login = new FrmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    lblUsuario.Text = AppDotNetContext.Usuario.Login;
                }
                else
                {
                    MessageBox.Show("Usuário não autorizado!");
                    this.Close();
                }

            }
        }

        private void FrmPrincipal_Enter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadFornecedores fornecedores = new FrmCadFornecedores
                {
                    MdiParent = this
                };
                fornecedores.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadProdutos produto = new FrmCadProdutos
                {
                    MdiParent = this
                };

                produto.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
