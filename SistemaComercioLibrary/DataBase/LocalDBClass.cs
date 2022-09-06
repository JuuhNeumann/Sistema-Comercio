using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace SistemaComercioLibrary.DataBase
{
    public class LocalDBClass
    {
        public string stringConn;
        public SqlConnection connDB;
        private SqlDataReader reader;
        private SqlCommand cmd;


        public LocalDBClass()
        {
            try
            {
                stringConn = "Data Source=DESKTOP-FSJV9IP;Initial Catalog=SistemaComercio;Persist Security Info=True;User ID=sa;Password=julia@2002";
                connDB = new SqlConnection(stringConn); //cria conexao
                connDB.Open(); //abre a conexão 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Login(string email, string senha)
        {
            cmd = new SqlCommand("select * from Login where email = @EMAIL and senha = @SENHA", connDB);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                return true;
            }

            reader.Close();
            reader.Dispose();
            return false;
        }

        public DataTable SQLQuery (string SQL) //metodo pra fazer consulta
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(SQL, connDB); //cria um pacote
                myCommand.CommandTimeout = 0; //espera o tempo necessario pra resposta do pacote
                var myReader = myCommand.ExecuteReader(); //envia o pacote
                dt.Load(myReader); //vai ter retorno do comando SQL q fez a consulta
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand (string SQL) //executar comando q retorna mensagem (criação, exclusao..)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, connDB); //cria um pacote
                myCommand.CommandTimeout = 0; //espera o tempo necessario pra resposta do pacote
                var myReader = myCommand.ExecuteReader(); //envia o pacote
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close ()
        {
            connDB.Close();
        }
    }
}
