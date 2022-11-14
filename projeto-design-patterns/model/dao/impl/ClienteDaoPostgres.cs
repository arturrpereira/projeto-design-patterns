using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using projeto_design_patterns.db;

namespace projeto_design_patterns.model.dao.impl
{
    public class ClienteDaoPostgres : ClieteDao
    {
        private NpgsqlConnection conn;

        public ClienteDaoPostgres(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        public void insert(Cliente obj)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Cliente (" +
                    "nome_cliente, " +
                    "senha_cliente, " +
                    "email_cliente," +
                    "rg_cliente," +
                    "cpf_cliente," +
                    "telefone_cliente," +
                    "datanasc_cliente," +
                    "endereco_cliente," +
                    "numero_endereco_cliente," +
                    "bairro_cliente)" +
                     "VALUES (" +
                     "@nome_cliente," +
                     "@senha_cliente," +
                     "@email_cliente," +
                     "@rg_cliente," +
                     "@cpf_cliente," +
                     "@telefone_cliente," +
                     "@datanasc_cliente," +
                     "@endereco_cliente," +
                     "@numero_endereco_cliente," +
                     "@bairro_cliente)";

                command.Parameters.AddWithValue("@nome_cliente", obj.nome_cliente);
                command.Parameters.AddWithValue("@senha_cliente", obj.senha_cliente);
                command.Parameters.AddWithValue("@email_cliente", obj.email_cliente);
                command.Parameters.AddWithValue("@rg_cliente", obj.rg_cliente);
                command.Parameters.AddWithValue("@cpf_cliente", obj.cpf_cliente);
                command.Parameters.AddWithValue("@telefone_cliente", obj.telefone_cliente);
                command.Parameters.AddWithValue("@datanasc_cliente", obj.datanasc_cliente);
                command.Parameters.AddWithValue("@endereco_cliente", obj.endereco_cliente);
                command.Parameters.AddWithValue("@numero_endereco_cliente", obj.numero_endereco_cliente);
                command.Parameters.AddWithValue("@bairro_cliente", obj.bairro_cliente);

                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public Cliente SelectEmailAndSenha(string email, string senha)
        {
            NpgsqlDataReader dr = null;
            Cliente obj = new Cliente();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Cliente WHERE email_cliente = @email_cliente AND " +
                    "senha_cliente = @senha_cliente";

                command.Parameters.AddWithValue("@email_cliente", email);
                command.Parameters.AddWithValue("@senha_cliente", senha);

                command.Connection = conn;
                dr = command.ExecuteReader();
                
                if(dr.HasRows)
                {
                    dr.Read();
                    obj.id_cliente = (int)dr["id_cliente"];
                    obj.nome_cliente = (string)dr["nome_cliente"];
                    obj.senha_cliente = (string)dr["senha_cliente"];
                    obj.email_cliente = (string)dr["email_cliente"];
                    obj.rg_cliente = (string)dr["rg_cliente"];
                    obj.cpf_cliente = (string)dr["cpf_cliente"];
                    obj.telefone_cliente = (string)dr["telefone_cliente"];
                    obj.datanasc_cliente = (string)dr["datanasc_cliente"];
                    obj.endereco_cliente = (string)dr["endereco_cliente"];
                    obj.numero_endereco_cliente = (int)dr["numero_endereco_cliente"];
                    obj.bairro_cliente = (string)dr["bairro_cliente"];

                    return obj;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //DB.closeConnection();
                DB.closeDataReader(dr);
            }

            return null;
        }
    }
}
