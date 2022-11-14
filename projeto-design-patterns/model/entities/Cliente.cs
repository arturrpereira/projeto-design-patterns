using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.model.entities
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string senha_cliente { get; set; }

        public string email_cliente { get; set; }

        public string rg_cliente { get; set; }

        public string cpf_cliente { get; set; }

        public string telefone_cliente { get; set; }

        public string datanasc_cliente { get; set; }

        public string endereco_cliente { get; set; }

        public int numero_endereco_cliente { get; set; }
        public string bairro_cliente { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id_cliente, string nome_cliente, string senha_cliente, string email_cliente, string rg_cliente, string cpf_cliente, string telefone_cliente, string datanasc_cliente, string endereco_cliente, int numero_endereco_cliente, string bairro_cliente)
        {
            this.id_cliente = id_cliente;
            this.nome_cliente = nome_cliente;
            this.senha_cliente = senha_cliente;
            this.email_cliente = email_cliente;
            this.rg_cliente = rg_cliente;
            this.cpf_cliente = cpf_cliente;
            this.telefone_cliente = telefone_cliente;
            this.datanasc_cliente = datanasc_cliente;
            this.endereco_cliente = endereco_cliente;
            this.numero_endereco_cliente = numero_endereco_cliente;
            this.bairro_cliente = bairro_cliente;
        }
    }
}
