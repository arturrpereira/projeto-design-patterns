using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using projeto_design_patterns.model.entities;
using projeto_design_patterns.model.services;

namespace projeto_design_patterns
{
    public partial class Login : Form
    {
        private ClienteService service = new ClienteService();
        private Cliente entity;
        public Login()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           Application.Exit();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                entity = getFormData();
                entity = service.buscaPorEmaileSenha(entity.email_cliente, entity.senha_cliente);

                if (entity == null)
                {
                    MessageBox.Show("Cliente não encontrado!");
                   
                }
                else
                {
                    Global.globalCliente = entity;
                    MessageBox.Show("Bem Vinde!");
                    if(email_cliente.Text != "operador")
                    {
                        index idx = new index();
                        idx.Show();
                        this.Hide();
                    }
                    else
                    {
                        gui.viewInserir inserir = new gui.viewInserir();
                        inserir.Show();
                        this.Hide();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            

            


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            viewCadastro vc = new viewCadastro();
            vc.Show();
            this.Hide();
        }

        private Cliente getFormData()
        {
            Cliente obj = new Cliente();

            if (email_cliente == null || senha_cliente == null)
            {
                MessageBox.Show("Os campos devem estar preenchidos!");
            }

            obj.email_cliente = email_cliente.Text;
            obj.senha_cliente = senha_cliente.Text;

            return obj;
        }

        private void txt_senha_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
