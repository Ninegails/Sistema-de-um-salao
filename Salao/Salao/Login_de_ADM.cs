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
    public partial class Login_de_ADM : Form
    {
        public Login_de_ADM()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastroADM frm = new CadastroADM();
            frm.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from Cadastro_ADM where Nome_Salao = @Login and Senha = @Senha";
            comando.Parameters.AddWithValue("@Login", txtlogin.Text);
            comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
            conexao.Open();

            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);

            if (consulta.Read() == true)
            {
                MessageBox.Show("Bem vindo!");
                conexao.Close();
                this.Hide();
                Area_ADM frm = new Area_ADM();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nome ou senha incorretos!");
                conexao.Close();
            }
        }
    }
}
