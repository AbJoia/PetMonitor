using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Pet_Monitor
{
    class PeriodoEmUso
    {
        public string CodPet { get; private set; }
        public string CodRastreador { get; private set; }

        public PeriodoEmUso()
        {
        }

        public PeriodoEmUso(string codPet)
        {
            CodPet = codPet;
        }

        
        public PeriodoEmUso(string codPet , string codRastreador) : this(codPet)
        {
            CodRastreador = codRastreador;
        }



        public DataTable BuscarRastreador(string senha)
        {
            string comando = "select cod_rastreador, dataAtivacao, id_tutor, username, status from tb_rastreador where senha = ? and status = 'disponivel'";            
            try
            {
                DataTable dataTableRastreador = new DataTable();
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                dataTableRastreador = cl_MysqlConect.BuscarRastreadoresDisponivel(comando, senha);
                return dataTableRastreador;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void InserirRastreadorPet()
        {            
            string comando = "insert into tb_periodo(id_periodo, id_pet, cod_rastreador, instanteInicial, instanteFinal) values (null,?,?,current_timestamp(),null);";
            try
            {
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.InsertPeriodoMysql(CodPet, CodRastreador,comando);
                UpdateRastreadorEmUso();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void UpdateRastreadorEmUso()
        {            
            try
            {
                string comando = "update tb_rastreador set status = 'Em Uso' where cod_Rastreador = ?;";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.UpdateStatus(comando, CodRastreador);                
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void UpdateRastreadorDisponivel(string codRastreador)
        {            
            try
            {                
                string comando = "update tb_rastreador set status = 'Disponivel' where cod_Rastreador = ?;";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.UpdateStatus(comando, codRastreador);
                comando = "update tb_periodo set instanteFinal = current_timestamp() where cod_Rastreador = ?";
                cl_MysqlConect.UpdateStatus(comando, codRastreador);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable BuscarRastreadorEmUso(string senha)
        {
            string comando = "select cod_rastreador, dataAtivacao, id_tutor, username, status from tb_rastreador where senha = ? and status = 'em uso'";
            try
            {
                DataTable dataTableRastreador = new DataTable();
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                dataTableRastreador = cl_MysqlConect.BuscarRastreadoresDisponivel(comando, senha);
                return dataTableRastreador;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable BuscarPlanilha()
        {
            string comando = "select * from tb_periodo";
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
