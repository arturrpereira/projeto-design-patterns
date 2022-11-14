using projeto_design_patterns.model.entities;
using projeto_design_patterns.model.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace projeto_design_patterns
{
    public partial class viewCadastro : Form
    {
        private ClienteService service = new ClienteService();
        private Cliente entity;
        public viewCadastro()
        {
            InitializeComponent();
        }

        private void viewCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
          Login vc =     new Login();
            vc.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*try
            {
                carro.marca = "teste";
                carro.modelo = "teste";
                carro.cor = "teste";
                carro.valor = 2;
                carro.tipo = "teste";
                carro.situacao_carro = "teste";

                carro.economico = true;

                popularService.save(carro);
                MessageBox.Show("Carro cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }*/
            try
            {
                entity = getFormData();
                service.save(entity);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
            }
            
        }

        private Cliente getFormData()
        {
            Cliente obj = new Cliente();

            obj.nome_cliente = nome_cliente.Text;
            obj.senha_cliente = senha_cliente.Text;
            obj.email_cliente = email_cliente.Text;
            obj.rg_cliente = rg_cliente.Text;
            obj.cpf_cliente = cpf_cliente.Text;
            obj.telefone_cliente = telefone_cliente.Text;
            obj.datanasc_cliente = datanasc_cliente.Text;
            obj.endereco_cliente = endereco_cliente.Text;
            obj.numero_endereco_cliente = Convert.ToInt32(numero_endereco_cliente.Text);
            obj.bairro_cliente = bairro_cliente.Text;

            return obj;
        }

    }
}
