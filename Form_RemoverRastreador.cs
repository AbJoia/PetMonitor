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
    public partial class Form_RemoverRastreador : Form
    {
        public Form_RemoverRastreador()
        {
            InitializeComponent();
        }

        private void bt_exibirDados_Click(object sender, EventArgs e)
        {            
            PeriodoEmUso periodoEmUso = new PeriodoEmUso();            
            dataGridView1.DataSource = periodoEmUso.BuscarRastreadorEmUso(txt_senha.Text);
        }

        private void bt_removerRastreador_Click(object sender, EventArgs e)
        {
            PeriodoEmUso periodoEmUso = new PeriodoEmUso();
            periodoEmUso.UpdateRastreadorDisponivel(txt_codRastreador.Text);
            MessageBox.Show("Rastreador removido do Pet. Final de periodo registrado.");
            clearBox();
        }

        public void clearBox()
        {
            txt_codRastreador.Clear();
            txt_senha.Clear();
        }
    }
}
