using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.dao
{
    public interface ClieteDao
    {
        void insert(Cliente obj);
        Cliente SelectEmailAndSenha(String email, String senha);
    }
}
