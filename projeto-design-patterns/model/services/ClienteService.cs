using projeto_design_patterns.model.dao;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.services
{
    public class ClienteService
    {
        private ClieteDao dao = DaoFactory.createClienteDao();
        
        public void save(Cliente obj)
        {
            dao.insert(obj);
        }

        public Cliente buscaPorEmaileSenha(string email, string senha)
        {
            return dao.SelectEmailAndSenha(email, senha);
        }
    }
}
