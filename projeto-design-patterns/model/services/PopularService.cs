using projeto_design_patterns.model.dao;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.services
{
    public class PopularService
    {
        private PopularDao dao = DaoFactory.createPopularDao();

        public void save(Popular obj)
        {
            dao.insert(obj);
        }
    }
}
