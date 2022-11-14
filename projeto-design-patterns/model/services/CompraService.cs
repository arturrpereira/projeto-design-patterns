using projeto_design_patterns.model.dao;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.services
{
    public class CompraService
    {
        private CompraDao dao = DaoFactory.createCompraDao();

        public void save(Compra obj)
        {
            dao.insert(obj);
        }
    }
}
