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
    public partial class ExcluirHorario : Form
    {
        public ExcluirHorario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Area_ADM frm = new Area_ADM();
            frm.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE from Agenda where Dia = @Dia and Horarios_Indisponiveis = @Horario";
            conexao.Open();

            string Data;
            Data = dtpDia.Value.ToString("dd-MM-yyyy");
            comando.Parameters.AddWithValue("@Dia", Data);
            comando.Parameters.AddWithValue("@Horario", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());

            int LinhasAfetadas;
            LinhasAfetadas = comando.ExecuteNonQuery();

            if (LinhasAfetadas > 0)
            {
                MessageBox.Show("Exclusão concluida com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir, tente novamente!");
            }
            conexao.Close();
        }

        private void ExcluirHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
