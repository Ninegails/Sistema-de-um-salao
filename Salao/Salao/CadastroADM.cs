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
    public partial class CadastroADM : Form
    {
        public CadastroADM()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeSalaoCadastro.Text == string.Empty || txtSenhaCadastro.Text == string.Empty)
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
            }
            else
            {
                string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";

                SqlConnection conexao2 = new SqlConnection(endereco);
                SqlConnection conexao = new SqlConnection(endereco);

                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conexao2;
                string cadastro1 = "select count(Senha) as total from Cadastro_ADM";
                comando2.CommandText = cadastro1;
                conexao2.Open();

                int val = 1;
                //Int32.TryParse(cadastro1, out val);

                val = (Int32)comando2.ExecuteScalar();
                //MessageBox.Show(val.ToString());
                conexao2.Close();

                //int LinhasAfetadas = comando.ExecuteNonQuery();
                if (val >= 2)
                {
                    MessageBox.Show("Limite máximo de cadastros atingidos!");
                }
                else
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "insert into Cadastro_ADM (Nome_Salao , Senha) values (@Nome_salao , @Senha)";
                    comando.Parameters.AddWithValue("@Nome_Salao", txtNomeSalaoCadastro.Text);
                    comando.Parameters.AddWithValue("@Senha", txtSenhaCadastro.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("cadastro concluido com sucesso!");
                    txtNomeSalaoCadastro.Clear();
                    txtSenhaCadastro.Clear();
                    conexao.Close();

                    txtNomeSalaoCadastro.Clear();
                    txtSenhaCadastro.Clear();
                }
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_de_ADM frm = new Login_de_ADM();
            frm.Show();
            this.Hide();
        }
    }
}
