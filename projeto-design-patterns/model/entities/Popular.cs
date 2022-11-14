using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Popular : Carro
    {
        public int id_popular { get; set; }
        public Boolean economico { get; set; }

        public Popular()
        {

        }

        public Popular(int id_popular, bool economico)
        {
          
            this.id_popular = id_popular;
            this.economico = economico;
        }

        public Popular(string marca, string modelo, string cor, float valor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.valor = valor;
            this.tipo = "POPULAR";
            this.situacao_carro = "ESTOQUE";
            this.economico = economico;
        }
    }
}
