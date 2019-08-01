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
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "select Senha from Cliente where Email = @Email";
            comando.Parameters.AddWithValue("@Email", txtEmail.Text);
            conexao.Open();

            SqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
            if (consulta.Read())
            {
                MessageBox.Show("A senha é: " + consulta.GetString(0));
            }
            else
            {
                MessageBox.Show("Não foi possivel achar uma senha com esse e-mail!");
            }

            conexao.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
