using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pet_Monitor
{
    class Cl_Pet
    {
        public string Id_Pet { get; private set; }
        public string Nome { get; private set; }
        public string Sexo { get; private set; }
        public string DataNascimento { get; private set; }
        public string Tipo { get; private set; }
        public string Raca { get; private set; }

        public Cl_Pet()
        {
        }

        public Cl_Pet(string nome, string sexo, string dataNascimento, string tipo, string raca)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Tipo = tipo;
            Raca = raca;
        }

        public Cl_Pet(string id_Pet, string nome, string sexo, string dataNascimento, string tipo, string raca) : this (nome, sexo, dataNascimento, tipo, raca )
        {
            Id_Pet = id_Pet;
        }

        public void InserirPet(string senha)
        {
            try
            {
                string comandoSelect = "select id_tutor, userName from tb_logintutor where senha = ?;";
                string apontarSelect = "@senha";
                string comando = "insert into tb_pet values(null, ?, ?, ?, ?, ?, ?, null, ?);";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                int id_tutor = cl_MysqlConect.SelectDadosMysql(comandoSelect, apontarSelect, senha);
                cl_MysqlConect.InsertPetMysql(comando, Nome, Sexo, DataNascimento, Raca, Tipo, id_tutor, senha);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO!" + erro);
            }
        }

        public void DeletePet(string codBusca)
        {
            try
            {
                string comando = "delete from tb_pet where id_pet = ? ;";
                string apontar = "@id_pet";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.DeleteRegMysql(int.Parse(codBusca), comando, apontar);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro!" + erro);
            }
        }

        public void AlterarPet(int form, string id_pet)
        {
            try
            {
                string comando = "update tb_pet set nomePet = ?, sexo = ?, dataNascimento = ?, raca = ?, tipo = ? where id_pet = ?;";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                cl_MysqlConect.UpdateMysql(comando, form, Nome, Sexo, DataNascimento, Raca, Tipo, id_pet);
            }
            catch(Exception erro)
            {
                throw erro;
            }
            
        }

        public DataTable BuscarRaca(string tipo)
        {
            try
            {
                string comando = "select nomeRaca from tb_classe where tipo = ?;";                
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();                
                DataTable dataRaca = cl_MysqlConect.ExibirDadosRaca(comando, tipo);                
                return dataRaca;
            }
            catch(Exception erro)
            {
                throw (erro);
            }
            
        }

        public DataTable ExibirPet()
        {
            try
            {
                string comando = "select id_pet, nomePet, sexo, dataNascimento, raca, tipo, id_tutor from tb_pet;";
                Cl_MysqlConect cl_MysqlConect = new Cl_MysqlConect();
                DataTable dataPet = new DataTable();
                dataPet = cl_MysqlConect.ExibirDados(comando);
                return dataPet;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
