using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Classe para conexão com banco de dados
namespace _231479_231464
{
    public class Banco
    {
        //criando as variaveis públicas para conexão que serão usadas em todo o projeto

        //connection responssavel pela conexão com o MySql
        public static MySqlConnection Conexao;

        //MySql command responssavel pelos códigos SQL
        public static MySqlCommand Comando;

        //Adapter insere dados em um dataTable
        public static MySqlDataAdapter Adaptador;

        //DataTable responsável por ligar o banco em controles com a propriedade DataSource
        public static DataTable dataTable;

        //função para estabelecer conexão com o banco de dados
        public static void AbrindoConexao()
        {
            try
            {
                //parametros para a conexão com o banco
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=");

                //abrindo a conexão com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //função para encerrar a conexão com o banco de dados
        public static void FechandoConexao()
        {
            try
            {
                //fechando a conexão com o banco de dados
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //criar banco e estrutura de tabelas
        public static void CriarBnaco()
        {
            try
            {
                //abrindo a conexao
                AbrindoConexao();

                //informando o comando SQL
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);

                //executando o comando (query) no SQL
                Comando.ExecuteNonQuery();

                //fechando a conexao
                FechandoConexao();
            }catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
