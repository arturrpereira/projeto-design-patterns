using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace projeto_design_patterns.db
{
    public class DB
    {
        private static NpgsqlConnection conn = null;

        public static NpgsqlConnection getConnection()
        {
            if (conn == null)
            {
                try
                {
                    string stringConnection = "Server=localhost;" +
                                              "Port=5432;" +
                                              "User ID=postgres;" +
                                              "Password=1234;" +
                                              "Database=db_design;";
                    conn = new NpgsqlConnection(stringConnection);
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return conn;
        }

		public static void closeConnection()
		{
			if (conn != null)
			{
				try
				{
					conn.Close();
				}
				catch (Exception e)
				{
					throw new Exception(e.Message);
				}
			}
		}

        public static void closeDataReader(NpgsqlDataReader dr)
        {
            if (dr != null)
            {
                try
                {
                    dr.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
	}
}
