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
    public class PopularDaoPostgres : PopularDao
    {
        private NpgsqlConnection conn;

        public PopularDaoPostgres(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
      
        public void insert(Popular obj)
        {
            try
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
                     "@marca," +
                     "@modelo," +
                     "@cor," +
                     "@valor," +
                     "@tipo," +
                     "@situacao_carro) RETURNING id_carro";

                command.Parameters.AddWithValue("@marca", obj.marca);
                command.Parameters.AddWithValue("@modelo", obj.modelo);
                command.Parameters.AddWithValue("@cor", obj.cor);
                command.Parameters.AddWithValue("@valor", obj.valor);
                command.Parameters.AddWithValue("@tipo", obj.tipo);
                command.Parameters.AddWithValue("@situacao_carro", obj.situacao_carro);
               

                command.Connection = conn;
                int id_carro = (int)command.ExecuteScalar();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Popular (" +
                    "fk_id_carro," +
                    "economico)" +
                     "VALUES (" +
                     "@fk_id_carro," +
                     "@economico)";

                command.Parameters.AddWithValue("@economico", obj.economico);
                command.Parameters.AddWithValue("@fk_id_carro", id_carro);

                command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
