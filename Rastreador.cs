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
    public partial class form_Rastreador : Form
    {
        public form_Rastreador()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InserirRastreador_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userId=root;database=db_pet_monitor");
                objcon.Open();
                MySqlCommand objcom = new MySqlCommand("select id_tutor, userName from tb_logintutor where senha = ?;", objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = txt_senha.Text;
                MySqlDataReader dataReader;
                dataReader = objcom.ExecuteReader();
                dataReader.Read();

                string id_tutor = dataReader.GetString(0);
                string userName = dataReader.GetString(1);
                
                objcon.Close();

                string status = "Disponivel";
                Cl_Rastreador cl_Rastreador = new Cl_Rastreador(txt_codRastreador.Text, id_tutor, userName, txt_senha.Text, status);
                cl_Rastreador.InserirRastreador();
                clearBox();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
            
        }

        private void bt_exibirRastreadores_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Rastreador cl_Rastreador = new Cl_Rastreador();
                dataGridView1.DataSource = cl_Rastreador.ExibirDadosRastreador();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void bt_DeleteRastreador_Click(object sender, EventArgs e)
        {
            try
            {                
                Cl_Rastreador cl_Rastreador = new Cl_Rastreador();
                cl_Rastreador.DeleteRastreador(int.Parse(txt_codRastreador.Text));
                clearBox();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
            
        }

        public void clearBox()
        {
            txt_codRastreador.Clear();
            txt_senha.Clear();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codRastreador_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
