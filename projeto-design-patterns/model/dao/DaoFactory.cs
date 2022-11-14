using projeto_design_patterns.db;
using projeto_design_patterns.model.dao.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.dao
{
    public class DaoFactory
    {
        public static CarroDao createCarroDao()
        {
            return new CarroDaoPostgres(DB.getConnection());
        }

        public static ClieteDao createClienteDao()
        {
            return new ClienteDaoPostgres(DB.getConnection());
        }

        public static CompraDao createCompraDao()
        {
            return new CompraDaoPostgres(DB.getConnection());
        }

        public static EsportivoDao createEsportivoDao()
        {
            return new EsportivoDaoPostgres(DB.getConnection());
        }

        public static LuxoDao createLuxoDao()
        {
            return new LuxoDaoPostgres(DB.getConnection());
        }

        public static PopularDao createPopularDao()
        {
            return new PopularDaoPostgres(DB.getConnection());
        }
    }
}
