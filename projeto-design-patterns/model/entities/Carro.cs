using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Carro
    {
        public int id_carro { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public float valor { get; set; }
        public string tipo { get; set; }
        public string situacao_carro { get; set; }

        public Carro()
        {

        }

        public Carro(int id_carro, string marca, string modelo, string cor, float valor, string tipo, string situacao_carro)
        {
            this.id_carro = id_carro;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.valor = valor;
            this.tipo = tipo;
            this.situacao_carro = situacao_carro;
        }
    }
}
