using Npgsql;
using projeto_design_patterns.db;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_design_patterns.model.dao.impl
{
    public class CarroDaoPostgres : CarroDao
    {
        private NpgsqlConnection conn;

        public CarroDaoPostgres(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        public List<Carro> findAll()
        {
            NpgsqlDataReader dr = null;
            Carro obj = new Carro();
            List<Carro> carros = new List<Carro>();
            
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Carro WHERE situacao_carro = 'ESTOQUE'";

                command.Connection = conn;
                dr = command.ExecuteReader();

                while(dr.Read())
                {
                    var id_carro = (int)dr["id_carro"];
                    var marca = (string)dr["marca"];
                    var modelo = (string)dr["modelo"];
                    var cor = (string)dr["cor"];
                    var valor = (float)(double)dr["valor"];
                    var tipo = (string)dr["tipo"];
                    var situacao_carro = (string)dr["situacao_carro"];

                    carros.Add(new Carro(id_carro, marca, modelo, cor, valor, tipo, situacao_carro));
                }
                return carros;
                
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

        public Carro findById(int id)
        {
            NpgsqlDataReader dr = null;
            Carro obj = new Carro();

            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Carro WHERE id_carro = @id_carro";

                command.Parameters.AddWithValue("@id_carro", id);

                command.Connection = conn;
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    obj.id_carro = (int)dr["id_carro"];
                    obj.marca = (string)dr["marca"];
                    obj.modelo = (string)dr["modelo"];
                    obj.cor = (string)dr["cor"];
                    obj.valor = (float)(double)dr["valor"];
                    obj.tipo = (string)dr["tipo"];
                    obj.situacao_carro = (string)dr["situacao_carro"];

                }
                return obj;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DB.closeDataReader(dr);
            }

            return null;
        }

        public void insert(Carro obj)
        {
            /*try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Carro (" +
                    "marca, " +
                    "modelo, " +
                    "cor," +
                    "valor," +
                    "tipo," +
                    "situacao_carro)" +
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

                command.Parameters.AddWithValue("@nome_cliente", obj.);
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
            }*/
        }
    }
}
