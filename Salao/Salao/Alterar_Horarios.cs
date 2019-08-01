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
    public partial class Alterar_Horarios : Form
    {
        public int linhasAfetadas;
        public Alterar_Horarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlConnection conexao = new SqlConnection(endereco);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            //comando.CommandText = "update Agenda set Dia = @Dia where Dia = @DiaAntigo and Horarios_Indisponiveis = @Horario and Horarios_Indisponiveis = @HorarioAntigo";
            string Data, Data1;
            Data = dtpDia.Value.ToString("dd-MM-yyyy");
            Data1 = dtpDiaAntigo.Value.ToString("dd-MM-yyyy");
            comando.Parameters.AddWithValue("@DiaAntigo", Data1);
            comando.Parameters.AddWithValue("@HorarioAntigo", cbxHorarioAntigo.Items[this.cbxHorarioAntigo.SelectedIndex].ToString());
            comando.Parameters.AddWithValue("@Dia", Data);
            comando.Parameters.AddWithValue("@Horario", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());
            conexao.Open();


            //linhasAfetadas = tabela.Rows.Count;

            SqlCommand comando2 = new SqlCommand("select COUNT(*) from Agenda where Dia = @Dia and Horarios_Indisponiveis = @Horario", conexao);
            int alterar = (int)comando2.ExecuteScalar();
            comando.Parameters.AddWithValue("@Dia", Data);
            comando.Parameters.AddWithValue("@Horario", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());

            //MessageBox.Show(linhasAfetadas.ToString());
            if (alterar > 0)
            {
                MessageBox.Show("Horario Indisponivel!");
            }
            else
            {
                comando.CommandText = "update Agenda set Dia = @Dia where Dia = @DiaAntigo and Horarios_Indisponiveis = @Horario and Horarios_Indisponiveis = @HorarioAntigo"; ;


                Data = dtpDia.Value.ToString("dd-MM-yyyy");

                comando.Parameters.AddWithValue("@Dia", Data);
                comando.Parameters.AddWithValue("@Horario", cbxHorario.Items[this.cbxHorario.SelectedIndex].ToString());

                //conexao.Open();


                linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Alteração concluida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocoreu um erro ao alterar, tente novamente.");
                }

                conexao.Close();

            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Area_ADM frm = new Area_ADM();
            frm.Show();
            this.Hide();
        }
    }
}
