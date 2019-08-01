using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salao
{
    public partial class AlterarInformacoes : Form
    {
        public AlterarInformacoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlteracaoEmail frm = new AlteracaoEmail();
            frm.Show();
            this.Hide();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            AlterarSenha frm = new AlterarSenha();
            frm.Show();
            this.Hide();
        }

        private void btnAlterarTelefone_Click(object sender, EventArgs e)
        {
            AlterarTelefone frm = new AlterarTelefone();
            frm.Show();
            this.Hide();
        }
    }
}
