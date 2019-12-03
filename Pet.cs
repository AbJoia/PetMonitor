using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Monitor
{
    public partial class Pet : Form
    {
        public Pet()
        {
            InitializeComponent();
        }

        private void Pet_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomePet_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_inserirPet_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Pet cl_Pet = new Cl_Pet(txt_nomePet.Text, cmb_sexoPet.Text, dt_nascPet.Text, cmb_tipoPet.Text, cmb_raca.Text);
                string senha = txt_senhaUsuario.Text;
                cl_Pet.InserirPet(senha);
                clearBox();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!" + erro);
            }
        }
        public void clearBox()
        {
            txt_cod.Clear();
            txt_codBusca.Clear();
            txt_nomePet.Clear();
            txt_senhaUsuario.Clear();
            cmb_raca.ResetText();
            cmb_sexoPet.ResetText();
            cmb_tipoPet.ResetText();
            
        }

        private void bt_exibirDados_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Pet cl_Pet = new Cl_Pet();
                dataGridView1.DataSource = cl_Pet.ExibirPet();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }            
        }

        private void cmb_sexoPet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_raca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_deletePet_Click(object sender, EventArgs e)
        {
            Cl_Pet cl_Pet = new Cl_Pet();
            cl_Pet.DeletePet(txt_codBusca.Text);
            clearBox();
        }

        private void bt_buscaPet_Click(object sender, EventArgs e)
        {
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userId=root;database=db_pet_monitor");
            objcon.Open();
            MySqlCommand objcom = new MySqlCommand("select * from tb_pet where id_pet = ?;", objcon);
            objcom.Parameters.Clear();
            objcom.Parameters.Add("@id_pet", MySqlDbType.Int32).Value = int.Parse(txt_codBusca.Text);
            MySqlDataReader dataReader;
            dataReader = objcom.ExecuteReader();
            dataReader.Read();

            txt_cod.Text = dataReader.GetString(0);
            txt_nomePet.Text = dataReader.GetString(1);
            cmb_sexoPet.Text = dataReader.GetString(2);
            dt_nascPet.Text = dataReader.GetString(3);
            cmb_raca.Text = dataReader.GetString(4);
            cmb_tipoPet.Text = dataReader.GetString(5);
            objcon.Close();                        
        }

        private void bt_alterarPet_Click(object sender, EventArgs e)
        {
            try
            {
                int form = 2;
                string id_pet = txt_cod.Text;
                Cl_Pet cl_Pet = new Cl_Pet(txt_cod.Text, txt_nomePet.Text, cmb_sexoPet.Text, dt_nascPet.Text, cmb_tipoPet.Text, cmb_raca.Text);
                cl_Pet.AlterarPet(form, id_pet);
                clearBox();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        private void bt_BuscarRaca_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmb_tipoPet.Text;
                Cl_Pet cl_Pet = new Cl_Pet();
                cmb_raca.DataSource = cl_Pet.BuscarRaca(tipo);
                cmb_raca.DisplayMember = "nomeRaca";
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void bt_adicionarRastreador_Click(object sender, EventArgs e)
        {
            form_AdionarRastreadorPet form_AdionarRastreadorPet = new form_AdionarRastreadorPet();
            form_AdionarRastreadorPet.codPet = txt_codBusca.Text;
            form_AdionarRastreadorPet.ShowDialog();
        }

        private void bt_RemoveRastreador_Click(object sender, EventArgs e)
        {
            Form_RemoverRastreador form_RemoverRastreador = new Form_RemoverRastreador();
            form_RemoverRastreador.ShowDialog();
        }
    }
}
