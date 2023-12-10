using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaCadastro;

namespace cadastroAtletas
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10667195;password=bDf34n5Fdn;database=sql10667195");
        public string mensagem;

        public bool insereAtleta(Atleta novoAtleta)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereAtleta", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novoAtleta.Nome);
                cmd.Parameters.AddWithValue("data_nasc", novoAtleta.Data_nasc);
                cmd.Parameters.AddWithValue("cidade", novoAtleta.Cidade);
                cmd.Parameters.AddWithValue("federado", novoAtleta.Federacao);
                cmd.Parameters.AddWithValue("clube", novoAtleta.Clube);
                cmd.ExecuteNonQuery();//executar banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }//fim do insere Atleta

        public bool insereClube(Clube novoClube)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insereClube", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novoClube.NomeClube);
                cmd.Parameters.AddWithValue("cidade", novoClube.CidadeClube);
                cmd.Parameters.AddWithValue("estado", novoClube.Estado);
                cmd.Parameters.AddWithValue("filiado", novoClube.Filiado);
                cmd.ExecuteNonQuery();//executar banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }//fim do insere Clube

        public DataTable listaAtletas()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaAtletas", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }//fim do try
            catch (MySqlException e)
            {
                mensagem = "Erro" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }//fim do lista Atletas

        public DataTable listaClubes()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaClube", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }//fim do try
            catch (MySqlException e)
            {
                mensagem = "Erro" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }//fim do lista clube

        public bool deletaAtleta(int idRemoveatleta)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeAtleta", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ID", idRemoveatleta);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();//executar banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "ERRO: " + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }//fim do deleta 

        public bool alteraAtleta(Atleta a, int idatleta)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraAtleta", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_atleta", idatleta);
            cmd.Parameters.AddWithValue("nome", a.Nome);
            cmd.Parameters.AddWithValue("data_nasc", a.Data_nasc);
            cmd.Parameters.AddWithValue("cidade", a.Cidade);
            cmd.Parameters.AddWithValue("federado", a.Federacao);
            cmd.Parameters.AddWithValue("clubes", a.Clube);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();//executar banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "ERRO:" + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }//fim do update atleta

        

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("sp_consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abre a conexão
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();//tabela virtual
                da.Fill(ds);//Passa os valores consultados para o data set
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException er)
            {
                mensagem = "ERRO" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }//fim do gera Hash

    }//fim da classe
}
