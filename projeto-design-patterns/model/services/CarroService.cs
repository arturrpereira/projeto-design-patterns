using projeto_design_patterns.model.dao;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.services
{
    public class CarroService
    {
        private CarroDao dao = DaoFactory.createCarroDao();

        public List<Carro> buscarTodosOsCarros()
        {
            return dao.findAll();
        }

        public Carro buscarPorId(int id)
        {
            return dao.findById(id);
        }
    }
}
