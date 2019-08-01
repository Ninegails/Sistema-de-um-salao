using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Salao
{
    public partial class AlterarTelefone : Form
    {
        public AlterarTelefone()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE Cliente set Telefone = @NovoTelefone where Telefone = @TelefoneAntigo";
            conexao.Open();

            comando.Parameters.AddWithValue("@TelefoneAntigo", mtxtTelefoneAntigo.Text);
            comando.Parameters.AddWithValue("@NovoTelefone", mtxtNovoTelefone.Text);

            int linhasAfetadas = comando.ExecuteNonQuery();
            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Alteração concluida com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocoreu um erro ao alterar o telefone tente novamente.");
            }

            conexao.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AlterarInformacoes frm = new AlterarInformacoes();
            frm.Show();
            this.Hide();
        }
    }
}
