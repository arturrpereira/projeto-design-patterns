using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Esportivo : Carro
    {
        public int id_esportivo { get; set; }
        public Boolean potencia_motor { get; set; }

        public Esportivo()
        {

        }

        public Esportivo(int id_esportivo, bool potencia_motor)
        {
            this.id_esportivo = id_esportivo;
            this.potencia_motor = potencia_motor;
        }

        public Esportivo(string marca, string modelo, string cor, float valor, Boolean potencia_motor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.valor = valor;
            this.tipo = "ESPORTIVO";
            this.situacao_carro = "ESTOQUE";
            this.potencia_motor = potencia_motor;
        }
    }
}
