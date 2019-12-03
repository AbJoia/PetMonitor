using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Monitor
{
    public partial class Form_Relatorio : Form
    {
        public Form_Relatorio()
        {
            InitializeComponent();
        }

        private void bt_planiPeriodo_Click(object sender, EventArgs e)
        {
            PeriodoEmUso periodoEmUso = new PeriodoEmUso();            
            dataGridView1.DataSource = periodoEmUso.BuscarPlanilha();
        }

        private void bt_planiLocalizacao_Click(object sender, EventArgs e)
        {
            Cl_Localizacao cl_Localizacao = new Cl_Localizacao();
            dataGridView1.DataSource = cl_Localizacao.buscarRelatorioLocalizacao();
        }
    }
}
