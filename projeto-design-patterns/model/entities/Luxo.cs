using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Luxo : Carro
    {
        public int id_luxo { get; set; }
        public Boolean teto_solar { get; set; }
        public Boolean banco_couro { get; set; }

        public Luxo()
        {

        }

        public Luxo(int id_luxo, bool teto_solar, bool banco_couro)
        {
            this.id_luxo = id_luxo;
            this.teto_solar = teto_solar;
            this.banco_couro = banco_couro;
        }

        public Luxo(string marca, string modelo, string cor, float valor, Boolean teto_solar, Boolean banco_couro)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.valor = valor;
            this.tipo = "LUXO";
            this.situacao_carro = "ESTOQUE";
            this.teto_solar = teto_solar;
            this.banco_couro = banco_couro;
        }
    }
}
