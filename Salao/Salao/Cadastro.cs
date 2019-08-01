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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty || txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtConfirmarSenha.Text == string.Empty)
            {
                MessageBox.Show("Todos os campos precisam estar preenchidos!");
            }
            else
            {
                string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
                SqlConnection conexao = new SqlConnection(endereco);

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "insert into Cliente (Nome , Email , Telefone , Senha) values (@Nome , @Email , @Telefone , @Senha)";
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                comando.Parameters.AddWithValue("@Telefone", mtxtTelefone.Text);
                comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
                conexao.Open();

                int linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cadastro concluido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocoreu um erro ao cadastrar tente novamente.");
                }
                conexao.Close();
            }

            if (txtConfirmarSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas não são iguais, por favor digite novamente.", "Atenção!", MessageBoxButtons.OK);
            }



        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
