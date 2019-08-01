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
    public partial class Area_ADM : Form
    {
        public Area_ADM()
        {
            InitializeComponent();
        }

        private void Area_ADM_Load(object sender, EventArgs e)
        {
            String endereco = "server=localhost\\SQLEXPRESS;database=Salao;UID=sa;password=123456";
            SqlDataAdapter da = new SqlDataAdapter("select * from Agenda", endereco);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            
            DataSet ds = new DataSet();
            da.Fill(ds, "Agenda");
            dataGridADM.DataSource = ds.Tables["Agenda"].DefaultView;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastroADM frm = new CadastroADM();
            frm.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar_Horarios frm = new Alterar_Horarios();
            frm.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirHorario frm = new ExcluirHorario();
            frm.Show();
            this.Hide();
        }
    }
}
