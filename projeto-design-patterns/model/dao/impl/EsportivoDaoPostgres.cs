﻿using Npgsql;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_design_patterns.model.dao.impl
{
    public class EsportivoDaoPostgres : EsportivoDao
    {
        private NpgsqlConnection conn;

        public EsportivoDaoPostgres(NpgsqlConnection conn)
        {
            this.conn = conn;
        }

        public void insert(Esportivo obj)
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
                command.CommandText = "INSERT INTO Esportivo (" +
                    "potencia_motor," +
                    "fk_id_carro)" +
                     "VALUES (" +
                     "@potencia_motor," +
                     "@fk_id_carro)";

                command.Parameters.AddWithValue("@fk_id_carro", id_carro);
                command.Parameters.AddWithValue("@potencia_motor", obj.potencia_motor);
       
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
