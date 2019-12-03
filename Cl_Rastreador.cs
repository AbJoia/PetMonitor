using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pet_Monitor
{
    class Cl_Rastreador
    {
        
        public string CodRastreador { get; private set; }        
        public string Id_tutor { get; private set; }
        public string Username { get; private set; }
        public string Senha { get; private set; }
        public string Status { get; private set; }

        public Cl_Rastreador()
        {

        }

        public Cl_Rastreador(string codRastreador, string id_tutor, string userName, string senha, string status)
        {            
            CodRastreador = codRastreador;
            Id_tutor = id_tutor;
            Username = userName;
            Senha = senha;
            Status = status;
        }

        public void InserirRastreador()
        {
            string comando = "insert into tb_rastreador(cod_Rastreador, dataAtivacao, id_tutor, userName, senha, status) values (?,current_timestamp(),?,?,?,?);";
            try
            {                
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();                
                cl_MysqlConect.InsertRastreadorMysql(CodRastreador, Id_tutor, Username, Senha, Status, comando);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void DeleteRastreador(int codRastreador)
        {
            string comDeleteTutor = "delete from tb_rastreador where cod_Rastreador = ?";
            string apontar = "@cod_ratreador";
            try
            {                
                Cl_MysqlConect objcon = new Cl_MysqlConect();
                objcon.DeleteRegMysql(codRastreador, comDeleteTutor, apontar);

            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + error);
            }

        }

        public DataTable ExibirDadosRastreador()
        {
            string comando = "select cod_rastreador, dataAtivacao, id_tutor, username, status from tb_rastreador;";
            try
            {
                DataTable dataTableRastreador = new DataTable();
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                dataTableRastreador = cl_MysqlConect.ExibirDados(comando);
                return dataTableRastreador;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


    }
}
