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
    public partial class Form_tutor : Form
    {
        public Form_tutor()
        {
            InitializeComponent();
        }

        private void txt_nomeTutor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showTest_Click(object sender, EventArgs e)
        {
            
        }

        private void InserirTutor_Click(object sender, EventArgs e)
        {
            try
            {
                Tutor tutor = new Tutor(txt_nomeTutor.Text, txt_sobreNomeTutor.Text, txt_emailTutor.Text, txt_usernameTutor.Text, txt_senhaTutor.Text);
                tutor.InserirDados();
                clearBox();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        }

        private void bt_deleteTutor_Click(object sender, EventArgs e)
        {
            try
            {                 
                Tutor tutor = new Tutor();
                tutor.DeleteTutor(txt_CodBusca.Text);
                clearBox();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_exibirDados_Click(object sender, EventArgs e)
        {
            try
            {
                Tutor tutor = new Tutor();
                dataGridView1.DataSource = tutor.ExibirDadosTutor();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void bt_select_Click(object sender, EventArgs e)
        {            
            try
            {                
                //Tutor tutor = new Tutor();
                
                //tutor.SelectTutor(txt_CodBusca.Text);
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;userId=root;database=db_pet_monitor");
                objcon.Open();
                MySqlCommand objcom = new MySqlCommand("select * from tb_logintutor where id_tutor = ?;", objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@id_tutor", MySqlDbType.Int32).Value = int.Parse(txt_CodBusca.Text);
                MySqlDataReader dataReader;
                dataReader = objcom.ExecuteReader();
                dataReader.Read();

                txt_codTutor.Text = dataReader.GetString(0);
                txt_nomeTutor.Text = dataReader.GetString(1);
                txt_sobreNomeTutor.Text = dataReader.GetString(2);
                txt_emailTutor.Text = dataReader.GetString(3);
                txt_usernameTutor.Text = dataReader.GetString(4);
                txt_senhaTutor.Text = dataReader.GetString(5);

                objcon.Close();
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
        }

        private void Form_tutor_Load(object sender, EventArgs e)
        {

        }

        private void txt_CodBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_updateTutor_Click(object sender, EventArgs e)
        {
            try
            {
                Tutor tutor = new Tutor(txt_codTutor.Text, txt_nomeTutor.Text, txt_sobreNomeTutor.Text, txt_emailTutor.Text, txt_usernameTutor.Text, txt_senhaTutor.Text);
                tutor.UpdateTutor();
                clearBox();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro!" + erro);
            }
            
        }
        public void clearBox()
        {
            txt_CodBusca.Clear();
            txt_codTutor.Clear();
            txt_nomeTutor.Clear();
            txt_sobreNomeTutor.Clear();
            txt_emailTutor.Clear();
            txt_usernameTutor.Clear();
            txt_senhaTutor.Clear();
        }
    }

}
