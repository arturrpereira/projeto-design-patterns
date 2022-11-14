using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Compra
    {
        public int id_compra { get; set; }
        public string data_compra { get; set; }
        public float valor_compra { get; set; }

        public List<Carro> carros = new List<Carro>();
        public Cliente cliente { get; set; }

        public Compra()
        {

        }
        public Compra(int id_compra, string data_compra, float valor_compra, Cliente cliente)
        {
            this.id_compra = id_compra;
            this.data_compra = data_compra;
            this.valor_compra = valor_compra;
            this.cliente = cliente;
        }

        public void calcularTotal()
        {
            foreach(Carro car in carros)
            {
                this.valor_compra += car.valor;
            }
        }
    }
}
