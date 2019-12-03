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
    public partial class form_AdionarRastreadorPet : Form
    {
        public form_AdionarRastreadorPet()
        {
            InitializeComponent();
        }

        public string codPet { get; set; }

        private void form_AdionarRastreadorPet_Load(object sender, EventArgs e)
        {
            if (!this.codPet.Equals(""))
            {
                txt_codPet.Text = this.codPet;
            }
        }

        private void bt_buscarRastreadoresDisponiveis_Click(object sender, EventArgs e)
        {
            string senha = txt_senha.Text;            
            try
            {
                PeriodoEmUso periodoEmUso = new PeriodoEmUso(senha);
                dataGridView1.DataSource = periodoEmUso.BuscarRastreador(senha);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void bt_adicionarRastreador_Click(object sender, EventArgs e)
        {
            string codPet = txt_codPet.Text;
            string codRastreador = txt_codRastreador.Text;
            PeriodoEmUso periodoEmUso = new PeriodoEmUso(codPet, codRastreador);
            periodoEmUso.InserirRastreadorPet();
            MessageBox.Show("Rastreador adicionado. Inicio de periodo registrado.");
            clearBox();

        }

        public void clearBox()
        {
            txt_codRastreador.Clear();
            txt_senha.Clear();
        }

        private void bt_gerarLocalizacao_Click(object sender, EventArgs e)
        {
            
        }
    }

}

