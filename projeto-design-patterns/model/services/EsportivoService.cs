﻿using projeto_design_patterns.model.dao;
using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.services
{
    public class EsportivoService
    {
        private EsportivoDao dao = DaoFactory.createEsportivoDao();

        public void save(Esportivo obj)
        {
            dao.insert(obj);
        }
    }
}
