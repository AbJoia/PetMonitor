using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pet_Monitor
{
    class Tutor
    {
        Cl_MysqlConect cl_MysqlConect;

        public string CodigoTutor { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Senha { get; private set; }

        public Tutor()
        {

        }

        public Tutor(string nome, string sobrenome, string email, string username, string senha)
        {           
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Username = username;
            Senha = senha;
        }

        public Tutor(string id_tutor, string nome, string sobrenome, string email, string username, string senha) : this(nome, sobrenome, email, username, senha)
        {
            CodigoTutor = id_tutor;
        }
                
        public void InserirDados()
        {
            string comando = "insert into tb_loginTutor values(null, ?, ?, ?, ?, ?)";            
            try
            {                
                cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.InsertTutorMysql(Nome, Sobrenome, Email, Username, Senha, comando);
            }
            catch(Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }

        public void DeleteTutor(string codBusca)
        {
            string comDeleteTutor = "delete from tb_loginTutor where id_tutor = ?";
            string apontar = "@id_tutor";
            try
            {
                CodigoTutor = codBusca;
                Cl_MysqlConect objcon = new Cl_MysqlConect();
                objcon.DeleteRegMysql(int.Parse(CodigoTutor), comDeleteTutor, apontar);

            }catch(Exception error)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + error);
            }
            
        }
                
        public void UpdateTutor()
        {
            string comando = "update tb_logintutor set nome = ?, sobrenome = ?, email = ?, userName = ?, senha = ? where id_tutor = ?;";
            int form = 1;
            try
            {
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.UpdateMysql(comando, form, Nome, Sobrenome, Email, Username, Senha, CodigoTutor);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }

        public DataTable ExibirDadosTutor()
        {
            string comando = "select id_tutor, nome, sobrenome, email, userName from tb_logintutor;";
            try
            {
                DataTable dataTableTutor = new DataTable();
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                dataTableTutor = cl_MysqlConect.ExibirDados(comando);
                return dataTableTutor;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        

    }
}
