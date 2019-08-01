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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro frm = new Cadastro();
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
            comando.CommandText = "select * from Cliente where Email = @Email and Senha = @Senha";
            comando.Parameters.AddWithValue("@Email", txtLogin.Text);
            comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
            conexao.Open();

            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);

            if(consulta.Read() == true)
            {
                MessageBox.Show("Bem vindo!");
                conexao.Close();
                this.Hide();
                Consulta frm = new Consulta();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
                conexao.Close();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlterarInformacoes frm = new AlterarInformacoes();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroADM frm = new CadastroADM();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarSenha frm = new RecuperarSenha();
            frm.Show();
            this.Hide();
        }
    }
}
