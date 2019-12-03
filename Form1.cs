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
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void bt_tutor_Click(object sender, EventArgs e)
        {            
            try
            {
                Form_tutor form_Tutor = new Form_tutor();
                form_Tutor.ShowDialog();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        }

        private void bt_rastreador_Click(object sender, EventArgs e)
        {
            try
            {
                form_Rastreador form = new form_Rastreador();
                form.ShowDialog();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void bt_Pet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.ShowDialog();
        }

        private void bt_relatorios_Click(object sender, EventArgs e)
        {
            Form_Relatorio form_Relatorio = new Form_Relatorio();
            form_Relatorio.ShowDialog();
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
