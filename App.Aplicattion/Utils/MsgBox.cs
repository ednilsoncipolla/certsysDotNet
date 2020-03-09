using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Aplicattion.Utils
{
    public static class MsgBox
    {
        public static bool Confirmar(string pergunta, string titulo)
        {
            return MessageBox.Show(pergunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
