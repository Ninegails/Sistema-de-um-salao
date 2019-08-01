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
    public partial class Consulta : Form
    {
        public int linhasAfetadas;
        public string Data;
        public Consulta()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "select Horarios_Indisponiveis from Agenda where Dia = @Dia1 and Horarios_Indisponiveis = @Horario1";
            Data = dtpDia.Value.ToString("dd-MM-yyyy");
            comando.Parameters.AddWithValue("@Dia1", Data);
            comando.Parameters.AddWithValue("@Horario1", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());
            conexao.Open();
            SqlDataAdapter cmd = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            cmd.Fill(tabela);
            comando.ExecuteNonQuery();

            linhasAfetadas = tabela.Rows.Count;

            //MessageBox.Show(linhasAfetadas.ToString());
            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Horario Indisponivel!");
            }
            else
            {
                comando.CommandText = "insert into Agenda (Dia , Nome , Horarios_Indisponiveis , Telefone , Descrição) values (@Dia , @Nome , @Horario , @Telefone , @Descricao)";


                Data = dtpDia.Value.ToString("dd-MM-yyyy");

                comando.Parameters.AddWithValue("@Dia", Data);
                comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                comando.Parameters.AddWithValue("@Horario", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());
                comando.Parameters.AddWithValue("@Telefone", mtxtTelefone.Text);
                comando.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                //conexao.Open();


                linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Agendamento concluido com sucesso!");
                    dataGridHorario.Update();
                    dataGridHorario.Refresh();
                }
                else
                {
                    MessageBox.Show("Ocoreu um erro ao agendar tente novamente.");
                }

                conexao.Close();
                Consulta_Load(null, null);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            String endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("select * from Agenda", endereco);
            DataTable dt = new DataTable();
            da.Fill(dt); //Now this DataTable is having all the columns lets say
                         /* Now take another temporary DataTable to display only particular columns*/
            DataTable tempDT = new DataTable();
            tempDT = dt.DefaultView.ToTable(true, "Horarios_Indisponiveis");
            //Now bind this to DataGridView
            dataGridHorario.DataSource = tempDT;
        }

        private void dataGridHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
