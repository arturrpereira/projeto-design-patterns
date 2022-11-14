using Npgsql;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_design_patterns.model.dao.impl
{
    public class CompraDaoPostgres : CompraDao
    {
        private NpgsqlConnection conn;

        public CompraDaoPostgres(NpgsqlConnection conn)
        {
            this.conn = conn;
        }

        public void insert(Compra obj)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Compra (" +
                    "fk_id_cliente, " +
                    "data_compra, " +
                    "valor_compra)" +
                    " VALUES (" +
                    "@fk_id_cliente," +
                    "@data_compra," +
                    "@valor_compra) RETURNING id_compra";

                command.Parameters.AddWithValue("@fk_id_cliente", obj.cliente.id_cliente);
                command.Parameters.AddWithValue("@data_compra", obj.data_compra);
                command.Parameters.AddWithValue("@valor_compra", obj.valor_compra);
                
                command.Connection = conn;
                int id_compra = (int)command.ExecuteScalar();

                foreach (Carro car in obj.carros)
                {
                    try
                    {

                        command.CommandText = "INSERT INTO listadecompra (" +
                            "compra_id_compra, " +
                            "carro_id_carro)" +
                            " VALUES (" + id_compra + ", " + car.id_carro + ")";
                                                   
                        command.Connection = conn;
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE Carro SET situacao_carro = 'VENDIDO' " +
                            "WHERE id_carro = " + car.id_carro;
                           
                        command.Connection = conn;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
