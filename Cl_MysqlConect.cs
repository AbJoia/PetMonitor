using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace Pet_Monitor
{
    class Cl_MysqlConect
    {
        string conect = ("server=localhost;port=3306;userId=root;database=db_pet_monitor");
        MySqlConnection objcon = null;
        MySqlCommand objcom;

        public void InsertTutorMysql(string nome, string sobreNome, string email, string userName, string senha, string comando)
        {
            try
            { 
                objcon = new MySqlConnection(conect);                
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
                objcom.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 50).Value = sobreNome;
                objcom.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
                objcom.Parameters.Add("@username", MySqlDbType.VarChar, 50).Value = userName;
                objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;
                objcom.ExecuteNonQuery();
                objcon.Close();
                System.Windows.Forms.MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
            
        }

        public void InsertRastreadorMysql(string cod_Rastreador, string id_tutor, string userName, string senha, string status, string comando)
        {
            try
            {                
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@cod_Rastreador", MySqlDbType.Int32).Value = int.Parse(cod_Rastreador);
                objcom.Parameters.Add("@id_tutor", MySqlDbType.Int32).Value = int.Parse(id_tutor);
                objcom.Parameters.Add("@userName", MySqlDbType.VarChar, 50).Value = userName;
                objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;
                objcom.Parameters.Add("@status", MySqlDbType.VarChar, 10).Value = status;
                objcom.ExecuteNonQuery();
                objcon.Close();
                System.Windows.Forms.MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }

        }

        public void InsertPetMysql(string comando, string nome, string sexo, string dataNascimento, string raca, string tipo, int id_tutor, string senha)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
                objcom.Parameters.Add("@sexo", MySqlDbType.VarChar, 5).Value = sexo;
                objcom.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = DateTime.Parse(dataNascimento);
                objcom.Parameters.Add("@raca", MySqlDbType.VarChar, 50).Value = raca;
                objcom.Parameters.Add("@tipo", MySqlDbType.VarChar, 15).Value = tipo;
                objcom.Parameters.Add("@id_tutor", MySqlDbType.Int32, 2).Value = id_tutor;
                objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;
                objcom.ExecuteNonQuery();
                objcon.Close();
                System.Windows.Forms.MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }

        }

        public void InsertPeriodoMysql(string cod_Pet, string cod_Rastreador, string comando)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@id_pet", MySqlDbType.Int32).Value = int.Parse(cod_Pet);
                objcom.Parameters.Add("@cod_Rastreador", MySqlDbType.Int32).Value = int.Parse(cod_Rastreador);                
                objcom.ExecuteNonQuery();
                objcon.Close();                
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }

        public void InsertLocalizacaoMysql(string latitude, string longitude, string cod_rastreador, string comando)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@latitude", MySqlDbType.Double).Value = double.Parse(latitude);
                objcom.Parameters.Add("@longitude", MySqlDbType.Double).Value = double.Parse(longitude);
                objcom.Parameters.Add("@cod_Rastreador", MySqlDbType.Int32).Value = int.Parse(cod_rastreador);
                objcom.ExecuteNonQuery();
                objcon.Close();
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }


        public void DeleteRegMysql(int codigo, string comando, string apontar)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add(apontar, MySqlDbType.Int32).Value = codigo;
                objcom.ExecuteNonQuery();
                objcon.Close();
                System.Windows.Forms.MessageBox.Show("Registro deletado com sucesso!");
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }

        public int SelectDadosMysql(string comando, string apontar, string senha)
        {
            try
            {
                Cl_Pet cl_Pet = new Cl_Pet();             
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add(apontar, MySqlDbType.VarChar, 50).Value = senha;
                MySqlDataReader dataReader;
                dataReader = objcom.ExecuteReader();
                dataReader.Read();
                int id_tutor = int.Parse(dataReader.GetString(0));
                objcon.Close();
                
                return id_tutor;                 
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        

        public void UpdateMysql(string comando, int form, string dado1, string dado2, string dado3, string dado4, string dado5, string dado6)
        {              
            try
            {
                objcon = new MySqlConnection(conect);                

                if (form == 1)
                {
                    objcon.Open();
                    objcom = new MySqlCommand(comando, objcon);
                    objcom.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = dado1;
                    objcom.Parameters.Add("@sobrenome", MySqlDbType.VarChar, 50).Value = dado2;
                    objcom.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = dado3;
                    objcom.Parameters.Add("@userName", MySqlDbType.VarChar, 50).Value = dado4;
                    objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = dado5;
                    objcom.Parameters.Add("@id_tutor", MySqlDbType.Int32).Value = int.Parse(dado6);
                    objcom.ExecuteNonQuery();
                    objcon.Close();
                    System.Windows.Forms.MessageBox.Show("Atualizado com sucesso!");
                }
                else if (form == 2)
                {
                    objcon.Open();
                    objcom = new MySqlCommand(comando, objcon);
                    objcom.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = dado1;
                    objcom.Parameters.Add("@sexo", MySqlDbType.VarChar, 50).Value = dado2;
                    objcom.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = DateTime.Parse(dado3);
                    objcom.Parameters.Add("@raca", MySqlDbType.VarChar, 50).Value = dado4;
                    objcom.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = dado5;
                    objcom.Parameters.Add("@id_pet", MySqlDbType.Int32).Value = int.Parse(dado6);
                    objcom.ExecuteNonQuery();
                    objcon.Close();
                    System.Windows.Forms.MessageBox.Show("Atualizado com sucesso!");
                }
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void UpdateStatus(string comando, string codRastreador)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcon.Open();
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Clear();
                objcom.Parameters.Add("@cod_Rastreador", MySqlDbType.Int32).Value = int.Parse(codRastreador);
                objcom.ExecuteNonQuery();
                objcon.Close();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDados(string comando)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcom = new MySqlCommand(comando, objcon);                
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();                
                mySqlDataAdapter.SelectCommand = objcom;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable BuscarRastreadoresDisponivel(string comando, string senha)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Add("@senha", MySqlDbType.VarChar, 50).Value = senha;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = objcom;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable ExibirDadosRaca(string comando, string tipo)
        {
            try
            {
                objcon = new MySqlConnection(conect);
                objcom = new MySqlCommand(comando, objcon);
                objcom.Parameters.Add("@tipo", MySqlDbType.VarChar, 15).Value = tipo;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = objcom;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);                
                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        
    }
}
