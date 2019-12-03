using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pet_Monitor
{
    class Cl_Localizacao
    {
        public string Id_localizacao { get; private set; }
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }
        public string Cod_rastreador { get; private set; }

        public Cl_Localizacao()
        {
        }

        public Cl_Localizacao(string id_localizacao, string latitude, string longitude, string cod_rastreador)
        {
            Id_localizacao = id_localizacao;
            Latitude = latitude;
            Longitude = longitude;
            Cod_rastreador = cod_rastreador;
        }

        public void InserirLocalizacao()
        {
            string comando = "insert into tb_localizacao(id_localizacao, latitude, longitude, instante, cod_rastreador) values (null,?,?,current_timestamp(),?);";
            try
            {
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.InsertLocalizacaoMysql(Latitude, Longitude, Cod_rastreador, comando);
                
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void DeleteLocalizacao()
        {
            string comDelete = "delete from tb_localizacao where id_localizacao = ?";
            string apontar = "@id_localizacao";
            try
            {
                Cl_MysqlConect objcon = new Cl_MysqlConect();
                objcon.DeleteRegMysql(int.Parse(Id_localizacao), comDelete, apontar);

            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + error);
            }
        }                

        public DataTable buscarRelatorioLocalizacao()
        {
            string comando = "select * from tb_localizacao;";
            try
            {
                DataTable dataTableLocalizacao = new DataTable();
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                dataTableLocalizacao = cl_MysqlConect.ExibirDados(comando);
                return dataTableLocalizacao;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
